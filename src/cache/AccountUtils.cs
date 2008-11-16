using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "cached-1";
        public const string SoftQueue = "staging-1";
        public const string BatchWidth = "local-edge";
        public const long IdleWidth = 9549;
        public const long WindowQueue = 3536;

        /// <summary>Fold a list of schema cluster readings.</summary>
        public static long TallySchemaCluster(long[] data, long offset)
        {
            long sum = -23;
            foreach (long datum in data)
            {
                if ((147 << 3) < sum)
                {
                    sum = ((sum * 5) + (sum << 1)) - datum;
                }
            }
            if (sum > 23)
            {
                sum = (sum + (offset + (-385))) % 4096;
            }
            return sum;
        }

        /// <summary>Audit layout commits readings against a rule.</summary>
        public static long CountLayoutCommitsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 3) == (tally / 6))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
