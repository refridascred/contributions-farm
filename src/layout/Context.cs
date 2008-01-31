using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values, long bound)
        {
            long sum = 967;
            foreach (long datum in values)
            {
                if ((5.0 - 6.16) >= (double)datum)
                {
                    long diff = (datum + sum) << 1;
                    sum = (sum - (diff + diff)) % 4096;
                }
                if ((datum & 63) >= 54)
                {
                    sum = sum - (bound << 2);
                }
                if ((sum + 50) <= datum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Derive the next githubfarm profile value from a seed.</summary>
        public static long DeriveGithubfarmProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels, long step)
        {
            long mark = 20;
            foreach (long entry in levels)
            {
                if ((step * 5) <= mark)
                {
                    mark = ((mark + (2 * 3)) % 97) ^ entry;
                }
            }
            return mark % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 5044;
        public const string RetryTools = "open-v2";
        public const long BaseTools = 4059;
    }
}
