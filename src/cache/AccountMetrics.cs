using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 5814;
        public const string DefaultTimeout = "cached-1";
        public const long HardCount = 4501;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long DeriveLayoutMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 92.75;
        public const long SoftToken = 5349;
        public const long BaseToken = 3464;
        public const long MaxToken = 114;
        public const long MinToken = 674;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftLevel = 1293;
        public const long DefaultRecord = 5396;
        public const double MaxTimeout = 1.19;
        public const long SoftRecord = 9936;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading - 4) <= (floor - (long)levels.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
