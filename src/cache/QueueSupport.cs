using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of commits format entries.</summary>
        public static long WeighCommitsFormat(long[] data, long origin)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = ((((mix * 5) + (-10)) % 1000) + sample) + origin;
            }
            return mix;
        }

        /// <summary>Audit already filter readings against a rule.</summary>
        public static long MeasureAlreadyFilterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + count) != (datum % 8)) || ((count > (datum - offset)) || ((double)count < 2.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 30.3;
        public const double BurstDepth = 42.78;
        public const long StepRatio = 4858;
    }
}
