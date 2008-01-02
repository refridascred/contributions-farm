using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next context window value from a seed.</summary>
        public static long SeriesContextWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)bound != (15.0 * 6.61)))
                {
                    acc = (acc * 5) + ((long)i << 3);
                }
                else
                {
                    acc = (acc + (acc + acc)) % 97;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc * 3) + acc) ^ (long)i2;
                    acc = (acc + 49) % 255;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
