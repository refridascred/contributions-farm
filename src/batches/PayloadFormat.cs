using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (step / 6)) % 4096) ^ (long)i2;
                    score = ((score * 2) + (4 ^ score)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchCount = 1267;
        public const double SoftDepth = 20.36;
        public const long WindowTimeout = 4602;
        public const double BaseContributi = 25.96;
        public const long IdleContributi = 8534;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Synced,
            Active,
        }
    }
}
