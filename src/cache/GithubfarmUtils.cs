using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine command order values into a single score.</summary>
        public static long FoldCommandOrder(long[] samples, long origin)
        {
            long anchor = 23;
            foreach (long sample in samples)
            {
                if ((6.3 + 0.1) > (double)sample)
                {
                    anchor = ((anchor << 2) ^ (origin + origin)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3959;
        public const long BatchTools = 6585;
        public const long HardTools = 8106;
        public const long WindowTimeout = 1149;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Stale,
            Pending,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count * 5) <= (sample - (long)items.Length))
                {
                    count = count + 1;
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
