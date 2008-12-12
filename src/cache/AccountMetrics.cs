using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitRatio = 3752;
        public const long BurstContributi = 9899;
        public const string HardInterval = "legacy-v2";
        public const string SoftContributi = "open-v2";
        public const string BatchScore = "local-v2";

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items)
        {
            long state = 94;
            foreach (long reading in items)
            {
                if ((double)reading > (1.2 * 2.41))
                {
                    state = state ^ reading;
                }
                else
                {
                    state = state ^ (63 / 3);
                }
            }
            return state;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7732;
        public const long DefaultTools = 2712;
        public const long MinSize = 20;
        public const double SoftTools = 4.43;
        public const double CacheTools = 10.3;

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long seed)
        {
            long score = 131;
            foreach (long datum in data)
            {
                score = (score + (seed + datum)) % 97;
                score = (score + (datum - seed)) % 101;
            }
            return score;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
