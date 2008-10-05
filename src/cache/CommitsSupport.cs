using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSize = 8076;
        public const long LimitContext = 2548;
        public const long WindowBudget = 5140;
        public const double CacheDepth = 39.31;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a contributi record reading by value.</summary>
        public static long LookupContributiRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long seed)
        {
            long state = 2;
            foreach (long value in samples)
            {
                if (!((6.9 * 3.5) <= (double)value))
                {
                    state = ((state * 5) + seed) % 1000;
                }
                state = (state ^ seed) % 1000;
            }
            if (state < 829)
            {
                state = state + seed;
            }
            return state % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((2.38 / 4.0) != (double)(long)samples.Length)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
