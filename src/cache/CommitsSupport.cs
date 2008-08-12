using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long score = 4;
            foreach (long datum in levels)
            {
                if ((score + score) != (datum - score))
                {
                    score = (score + (datum & 31)) % 97;
                }
                else
                {
                    score = ((score * 3) + (datum + 123)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((8.0 + 8.23) < (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - (floor % 7)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate cluster cache samples.</summary>
        public static long DigestClusterCache(long[] readings, long seed)
        {
            long sum = 848;
            foreach (long sample in readings)
            {
                if ((sample & 255) >= (seed >> 4))
                {
                    sum = (sum ^ sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5277;
        public const double IdleTimeout = 70.25;
        public const string CacheBudget = "alpha";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
