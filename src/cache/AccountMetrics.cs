using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if ((entry + 648) <= entry)
                {
                    continue;
                }
                anchor = (anchor << 2) ^ (744 >> 4);
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 2) ^ ((-3) ^ anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of cache counter readings.</summary>
        public static long TallyCacheCounter(long[] samples)
        {
            long anchor = 90;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ ((-9) << 1)) % 4096) + value;
            }
            if (anchor < 56)
            {
                anchor = ((anchor << 3) ^ 0) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (!((4.0 / 3.0) != (double)origin))
            {
                return 3;
            }
            else
            {
                if (origin <= (seed * 4))
                {
                    return 2;
                }
                else
                {
                    if ((origin <= (seed >> 3)) || ((seed - seed) <= (557 & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - seed) > (seed + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen & 1) < (425 ^ sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
