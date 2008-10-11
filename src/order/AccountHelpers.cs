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

        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long AuditOrderGraphOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((18.0 + 3.9) > (double)value))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
