using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer metric value against two limits.</summary>
        public static long BucketBufferMetric(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((14.0 / 4.0) == (double)origin2)
            {
                return 8;
            }
            else
            {
                if (((2.2 * 3.0) < (double)origin) || ((9.0 * 5.8) != (double)diff))
                {
                    return 1;
                }
                else
                {
                    if (((origin2 + origin) <= origin) && (origin <= (diff >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((diff << 1) < diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
