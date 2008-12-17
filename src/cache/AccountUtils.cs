using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFactor = 62.67;
        public const long MinBudget = 8055;
        public const long StepFarm = 3818;
        public const long DefaultWidth = 403;
        public const double BaseScore = 81.63;

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "staging-v2";
        public const string IdleInterval = "strict-v2";
        public const long IdleSession = 9896;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(count <= (offset + 4)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
