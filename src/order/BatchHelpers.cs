using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) != (seen % 2))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long floor2)
        {
            if (((double)floor2 <= 5.94) || ((floor * 4) > (floor2 + floor2)))
            {
                return 3;
            }
            else
            {
                if (!((floor ^ floor2) >= floor2))
                {
                    return 2;
                }
                else
                {
                    if ((83 & 255) == (floor2 % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
