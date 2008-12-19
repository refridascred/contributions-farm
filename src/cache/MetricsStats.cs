using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) != (132 + 70))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2459;
        public const string HardCounter = "staging-v2";
        public const string BaseCounter = "latest";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
