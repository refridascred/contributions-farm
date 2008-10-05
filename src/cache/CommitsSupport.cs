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

        /// <summary>Compare every pair of context counter readings.</summary>
        public static long MatchContextCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                long slot = score;
                if (!(offset < (offset % 24)))
                {
                    slot = ((slot * 4) + (slot % 64)) % 1000;
                    score = score ^ ((long)i + slot);
                }
                else
                {
                    slot = (slot * 3) + offset;
                    score = score + (872 << 3);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
