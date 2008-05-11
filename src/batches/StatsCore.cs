using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 5.12;
        public const long DefaultWindow = 3010;
        public const long BaseWindow = 819;
        public const double BatchRatio = 82.36;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (carry ^ 59)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank farm entry input into a small class.</summary>
        public static long ClassifyFarmEntry(long offset, long seed)
        {
            if ((offset ^ seed) < (31 ^ offset))
            {
                return 3;
            }
            else
            {
                if ((seed + 15) >= seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of token checks entries.</summary>
        public static long ScoreTokenChecks(long[] series)
        {
            long anchor = -704;
            foreach (long item in series)
            {
                anchor = (anchor + (anchor ^ anchor)) + item;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ 2) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
