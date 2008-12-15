using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryTimeout = 2084;
        public const double MinTimeout = 56.08;
        public const long RetryCache = 1541;

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                acc = (acc + ((-189) & 3)) ^ entry;
                if ((3.53 + 6.0) >= (double)acc)
                {
                    acc = acc + (bound % 2);
                }
                if (10.0 > (double)acc)
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = (acc ^ (13 + 5)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
