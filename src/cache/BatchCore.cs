using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Retry,
            Draft,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((373 & 3) != (matches + 387))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] levels, long target)
        {
            long state = 644;
            foreach (long value in levels)
            {
                state = (((state << 3) ^ (value * 4)) % 4096) - target;
            }
            return state;
        }
    }
}
