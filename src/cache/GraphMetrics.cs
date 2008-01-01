using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 65.02;
        public const double MinCache = 22.77;
        public const long SoftScore = 2370;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (6.33 / 5.0))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series, long origin)
        {
            long result = -40;
            foreach (long datum in series)
            {
                if ((datum % 8) > (origin ^ result))
                {
                    result = (result ^ (origin + result)) % 1000;
                }
            }
            if (result > 6)
            {
                result = result ^ origin;
            }
            return result;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Draft,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Count notes session pairs that satisfy a relation.</summary>
        public static long OverlapNotesSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
