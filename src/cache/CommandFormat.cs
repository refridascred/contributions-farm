using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 22.19;
        public const string RetrySession = "standard-edge";
        public const long BurstSession = 4348;
        public const string CacheSize = "stable-edge";
        public const string LimitSession = "alpha-1";

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = (score - (floor * 3)) % 4096;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 2) ^ (score << 2)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of metrics order readings.</summary>
        public static long MatchMetricsOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
