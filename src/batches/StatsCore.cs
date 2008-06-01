using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell << 2) <= (cell + tally)) && ((cell + 3) >= (cell % 97)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long limit)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if ((acc >> 4) < (951 - acc))
                {
                    acc = (acc - (value - limit)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 6665;
        public const double BaseInterval = 32.0;
        public const long IdleReport = 427;
        public const double DefaultCount = 72.01;
        public const double WindowWidth = 62.96;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Total { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels, long seed)
        {
            long state = 910;
            foreach (long item in levels)
            {
                if ((state - seed) > (state - item))
                {
                    state = (state + (seed - item)) % 1000;
                }
            }
            if (state < 58)
            {
                state = state ^ ((long)levels.Length / 3);
            }
            return state % 4096;
        }
    }
}
