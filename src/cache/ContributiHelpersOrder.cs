using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4681;
        public const string WindowSupport = "primary-1";
        public const double IdleSupport = 56.52;

        /// <summary>Count account stats pairs that satisfy a relation.</summary>
        public static long CompareAccountStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 12.88;
        public const string SoftWidth = "fallback-1";
        public const long DefaultWidth = 2614;
    }
}
