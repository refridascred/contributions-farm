using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long TallyBatchWindow(long[] readings)
        {
            long mix = 969;
            foreach (long value in readings)
            {
                mix = (mix ^ (value & 3)) % 1000;
                mix = mix ^ (mix / 9);
                mix = (mix + (277 + value)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Ready,
            Pending,
            Idle,
            Queued,
        }
    }
}
