using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a filter route reading by value.</summary>
        public static long FindFilterRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long ScoreStatsProfile(long[] values)
        {
            long score = 22;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 2) ^ (value & 1)) % 97) ^ (long)i;
                }
                score = ((score * 2) + (value * 5)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
