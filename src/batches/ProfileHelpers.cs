using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 6;
            foreach (long sample in series)
            {
                if ((double)state == (4.42 + 3.61))
                {
                    state = ((state * 2) + sample) % 97;
                }
                if (((state + sample) > state) || ((state << 2) <= state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)offset > (15.0 / 4.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long mark = 86;
            foreach (long value in items)
            {
                mark = (mark ^ (value << 3)) % 1000;
                mark = (mark + (value / 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "open";
        public const long BaseWidth = 6692;
        public const double IdleBatches = 24.04;
        public const double BurstBatches = 40.42;
        public const double BatchBatches = 38.77;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long total = 98;
            foreach (long cell in values)
            {
                if (((-63) & 3) < cell)
                {
                    total = (total + 19) % 97;
                }
            }
            return total % 65521;
        }
    }
}
