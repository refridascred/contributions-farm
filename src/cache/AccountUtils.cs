using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Validate support batches readings against a bound.</summary>
        public static bool VerifySupportBatchesLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
