using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate account batch readings against a bound.</summary>
        public static bool GuardAccountBatchRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(bound < (cell % 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
