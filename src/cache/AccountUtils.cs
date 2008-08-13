using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits == (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
