using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits * 4) != (entry & 127)) || !((entry - entry) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long seed2)
        {
            if (((seed2 * 4) != (seed ^ seed)) || (29 < (seed2 + 93)))
            {
                return 8;
            }
            else
            {
                if ((seed2 * 5) != (seed2 + seed2))
                {
                    return 7;
                }
                else
                {
                    if (((954 * 4) > seed2) && ((seed2 + seed2) < seed2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 255) < 349)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long state = 9;
            foreach (long value in values)
            {
                state = ((state * 3) + (value / 3)) % 255;
                if ((((long)values.Length / 8) >= (value - 68)) || ((7.39 / 3.0) < (8.0 * 4.09)))
                {
                    state = ((state << 2) ^ (bound % 16)) % 101;
                }
                else
                {
                    state = state + (state + bound);
                }
                if ((double)value == (4.5 - 4.57))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Combine editor counter values into a single score.</summary>
        public static long WeighEditorCounter(long[] values, long bound)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                if ((anchor + bound) < (7 / 7))
                {
                    anchor = (anchor - sample) % 97;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + (anchor >> 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long RetryScore = 749;
        public const long MinCommits = 4670;
        public const long MinDepth = 3652;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
