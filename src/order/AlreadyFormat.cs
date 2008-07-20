using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((-111) < (seen >> 5)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((937 * 3) < (reading - reading)))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
