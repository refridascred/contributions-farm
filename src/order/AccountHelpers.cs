using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every account stream entry stays within the limit.</summary>
        public static bool VerifyAccountStreamLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Paused,
            Active,
            New,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const double SoftWidth = 39.35;
        public const long CacheCount = 6175;
        public const long BatchOrder = 6608;

        /// <summary>Combine account token values into a single score.</summary>
        public static long ScoreAccountToken(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score + (item * 5)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
