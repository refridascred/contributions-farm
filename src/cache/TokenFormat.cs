using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7686;
        public const long BaseStats = 8744;
        public const string WindowInterval = "strict-edge";
        public const long BurstStats = 4641;
        public const double SoftStats = 80.38;

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheBudget = "standard";
        public const long LimitBudget = 4106;
        public const string MinCount = "strict-edge";
        public const long DefaultLayout = 9034;
        public const long MinLayout = 7699;

        /// <summary>Match up queue schema samples.</summary>
        public static long OverlapQueueSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
