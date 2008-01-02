using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank token context input into a small class.</summary>
        public static long ClassifyTokenContext(long limit, long seed)
        {
            long delta = limit + seed;
            if ((limit - seed) != (delta / 5))
            {
                return 4;
            }
            else
            {
                if ((4 / 8) != (seed + delta))
                {
                    return 0;
                }
                else
                {
                    if ((seed + limit) == (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + 8) < (delta & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((7.46 + 6.0) <= (double)floor))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
