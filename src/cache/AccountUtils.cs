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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)bound > (0.4 / 6.0))
                {
                    mark = (mark + (mark * 2)) % 255;
                    mark = ((mark * 5) + (mark - bound)) % 101;
                }
                mark = (mark + mark) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
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
