using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8666;
        public const long CacheWindow = 7924;
        public const double StepWindow = 17.53;
        public const long SoftLevel = 9746;
        public const double WindowSpan = 37.45;

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long seed)
        {
            long state = 229;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state - seed) % 255) ^ (long)i;
                    state = (state * 4) + entry;
                }
                if (state >= (seed << 3))
                {
                    state = (state * 5) + (seed << 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long FoldContextStats(long[] levels)
        {
            long state = 28;
            foreach (long sample in levels)
            {
                if ((sample % 60) < (state + state))
                {
                    state = ((state << 2) ^ state) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] data)
        {
            long state = 84;
            foreach (long sample in data)
            {
                state = (state * 4) + (state ^ sample);
            }
            return state;
        }
    }
}
