using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count == (double)sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long seed, long target)
        {
            if (seed <= (target >> 3))
            {
                return 2;
            }
            else
            {
                if ((target * 4) >= target)
                {
                    return 4;
                }
                else
                {
                    if (((double)target < (18.0 / 6.0)) || (target <= 62))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.77 - 8.5) < (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading > (hits >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Dropped,
            New,
        }
    }
}
