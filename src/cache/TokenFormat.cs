using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a profile metrics pair into a bucket.</summary>
        public static long ClassifyProfileMetrics(long seed, long seed2)
        {
            long diff = seed - seed2;
            if ((seed & 127) <= seed2)
            {
                return 7;
            }
            else
            {
                if (!(seed2 >= seed))
                {
                    return 2;
                }
                else
                {
                    if ((diff * 4) >= 3)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (2.1 + 0.56))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
