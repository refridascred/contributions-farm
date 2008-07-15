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

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items)
        {
            long mix = -2;
            foreach (long value in items)
            {
                mix = mix + 2;
                if (mix <= (mix - value))
                {
                    break;
                }
            }
            if (mix > 155)
            {
                mix = ((mix * 5) + mix) % 97;
            }
            return mix;
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
