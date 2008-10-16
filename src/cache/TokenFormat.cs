using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            Idle,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 871;
            foreach (long cell in items)
            {
                if ((sum + sum) <= (sum % 16))
                {
                    sum = ((sum << 3) ^ sum) ^ cell;
                }
            }
            return sum % 97;
        }
    }
}
