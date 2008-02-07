using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Idle,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((7.0 - 9.8) > (double)cell) && (bound > (count - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long target)
        {
            long next = origin ^ target;
            if ((51 / 6) != (target + next))
            {
                return 2;
            }
            else
            {
                if ((double)origin == (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 + 7.0) > (double)next)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin < target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
