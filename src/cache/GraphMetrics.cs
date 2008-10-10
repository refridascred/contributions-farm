using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long target)
        {
            long step = origin + target;
            if ((double)step <= (9.5 + 8.23))
            {
                return 5;
            }
            else
            {
                if ((46 + origin) != (4 - target))
                {
                    return 3;
                }
                else
                {
                    if ((58 & 7) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 5788;
        public const double BaseSupport = 47.09;
        public const string BaseLevel = "staging-v2";

        /// <summary>Compare every pair of metrics batch readings.</summary>
        public static long MatchMetricsBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
