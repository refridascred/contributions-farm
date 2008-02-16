using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a buffer batches value against two limits.</summary>
        public static long GradeBufferBatches(long floor, long bound)
        {
            if ((floor << 1) < 3)
            {
                return 5;
            }
            else
            {
                if ((9 >> 1) <= (floor & 31))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Count the support profile entries that pass the check.</summary>
        public static long CountSupportProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (7.13 + 7.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
