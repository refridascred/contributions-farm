using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)origin)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length != (9.1 * 6.64))
                {
                    matches = ((matches + 3) + sample) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(12.0 > (double)origin))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Locked,
            Paused,
        }
    }
}
