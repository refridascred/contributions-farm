using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleDepth = 1226;
        public const long RetrySpan = 58;
        public const string BurstContributi = "latest";
        public const long HardContributi = 25;
        public const long BaseContributi = 6278;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((2 << 3) > (cell / 5))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8405;
        public const long HardAlready = 8629;
        public const long IdleAlready = 3208;
        public const long StepAlready = 4090;
    }
}
