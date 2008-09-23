using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data, long seed)
        {
            long acc = 93;
            foreach (long item in data)
            {
                if ((acc >= (acc & 7)) || ((seed & 63) < acc))
                {
                    acc = acc + (acc - item);
                }
            }
            return acc;
        }

        /// <summary>Measure how many already commits samples are out of range.</summary>
        public static long TallyAlreadyCommitsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 3) != (tally & 3))
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi record samples are out of range.</summary>
        public static long AuditContributiRecordGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count - limit) >= (datum * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Closed,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Rank checks channel input into a small class.</summary>
        public static long RankChecksChannel(long floor, long seed)
        {
            if ((seed % 5) <= (floor % 3))
            {
                return 6;
            }
            else
            {
                if (seed <= 95)
                {
                    return 3;
                }
                else
                {
                    if ((seed - floor) > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
