using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate metric account samples.</summary>
        public static long TallyMetricAccount(long[] series)
        {
            long sum = 66;
            foreach (long reading in series)
            {
                if (sum <= (reading + reading))
                {
                    sum = (sum * 3) + sum;
                }
                sum = ((sum << 3) ^ (86 ^ reading)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Idle,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 5930;
        public const long BaseBatch = 6795;
        public const long CacheFactor = 3616;
        public const long HardBatch = 4665;
        public const long BurstTimeout = 5420;
    }
}
