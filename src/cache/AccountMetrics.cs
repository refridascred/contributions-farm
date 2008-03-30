using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Done,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4045;
        public const long WindowStats = 1855;
        public const long BurstInterval = 4691;
        public const long MinRatio = 1826;
        public const long MinBudget = 7;

        /// <summary>Grade a record commits value against two limits.</summary>
        public static long BucketRecordCommits(long seed, long step)
        {
            long next = seed ^ step;
            if (next > seed)
            {
                return 6;
            }
            else
            {
                if (!((19.0 / 7.0) >= (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((step > next) || ((805 + next) < (seed & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >= (977 - seed)) && ((7.2 - 14.0) < (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long offset, long offset2)
        {
            long cur = offset ^ offset2;
            if ((18.0 / 8.0) == (double)cur)
            {
                return 7;
            }
            else
            {
                if (5 >= offset2)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long anchor = 861;
            foreach (long reading in levels)
            {
                if ((74 % 97) != (reading + reading))
                {
                    anchor = (anchor ^ reading) % 4096;
                }
            }
            if (anchor > 51)
            {
                anchor = (anchor + ((long)levels.Length - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - origin) <= (count - origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
