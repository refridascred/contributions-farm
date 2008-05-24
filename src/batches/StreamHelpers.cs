using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long bound)
        {
            long delta = target + bound;
            if (target > (delta + bound))
            {
                return 4;
            }
            else
            {
                if (!((delta ^ delta) == (bound + delta)))
                {
                    return 8;
                }
                else
                {
                    if ((bound ^ target) < (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((bound + (-145)) < (bound / 8)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches record samples.</summary>
        public static long FoldBatchesRecord(long[] items)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                if ((carry * 3) > sample)
                {
                    carry = (carry + (carry / 6)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Synced,
            Paused,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long anchor = 45;
            foreach (long datum in items)
            {
                anchor = anchor + (anchor - origin);
                if ((origin & 3) != (anchor % 100))
                {
                    anchor = anchor - (datum + origin);
                }
            }
            return anchor;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
