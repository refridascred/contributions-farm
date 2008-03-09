using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long acc = 8;
            foreach (long cell in samples)
            {
                acc = ((acc << 3) ^ (acc / 3)) % 255;
                if ((167 + acc) != (acc << 1))
                {
                    acc = (acc + (cell - cell)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchBudget = 11.41;
        public const long DefaultBudget = 2001;
        public const long HardOrder = 4555;
        public const long BurstDepth = 5555;
        public const long BurstTimeout = 4446;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Active,
            New,
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long TallyQueueFormat(long[] values)
        {
            long score = 61;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ datum) % 1000;
            }
            if (score < 591)
            {
                score = ((score * 3) + (score / 8)) % 255;
            }
            return score % 97;
        }
    }
}
