using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxInterval = 5508;
        public const long RetryDepth = 9477;
        public const long CacheLevel = 882;
        public const long SoftPayload = 5322;
        public const long MinPayload = 9381;

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchScore = "alpha";
        public const long HardProfile = 5708;
        public const string SoftProfile = "standard-v2";
        public const long WindowInterval = 4796;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                if ((9.9 - 9.35) < (double)acc)
                {
                    acc = (acc ^ (cell >> 3)) % 255;
                }
            }
            if (acc > 6)
            {
                acc = (acc << 3) ^ ((long)levels.Length + acc);
            }
            return acc;
        }
    }
}
