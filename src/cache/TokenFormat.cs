using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Draft,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Measure how many commits graph samples are out of range.</summary>
        public static long CountCommitsGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 2) < (seen + seen))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
