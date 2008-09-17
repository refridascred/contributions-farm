using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5510;
        public const double WindowDepth = 32.61;
        public const double DefaultBatch = 58.54;
        public const long MaxBatch = 5202;
        public const long LimitFactor = 5659;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((limit - (-7)) == (limit << 3)) || ((2.71 * 20.0) == (double)total))
                {
                    total = total + 93;
                }
                total = (total + (600 - limit)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((bound >= (833 * 2)) || (datum > (datum + bound))) && ((0.4 / 2.0) < (double)datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
