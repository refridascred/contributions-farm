using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Paused,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 9138;
        public const double BaseGraph = 4.81;
        public const long IdleRatio = 6190;
        public const long DefaultSpan = 4285;
    }
}
