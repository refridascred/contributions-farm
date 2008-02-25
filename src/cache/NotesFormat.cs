using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank metrics farm input into a small class.</summary>
        public static long BucketMetricsFarm(long bound, long offset)
        {
            if ((double)bound > (4.0 + 3.1))
            {
                return 8;
            }
            else
            {
                if ((758 * 5) >= offset)
                {
                    return 0;
                }
                else
                {
                    if ((bound & 31) != (bound << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= (3.4 * 0.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits batch samples are out of range.</summary>
        public static long AuditCommitsBatchMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)956)
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Paused,
            Pending,
            Active,
            Failed,
        }
    }
}
