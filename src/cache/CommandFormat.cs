using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item % 5) == (item - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Match up token stream samples.</summary>
        public static long CompareTokenStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
