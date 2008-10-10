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

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values)
        {
            long total = 9;
            foreach (long cell in values)
            {
                if ((cell ^ 378) <= ((-6) << 3))
                {
                    total = ((total * 2) + (33 + cell)) % 4096;
                }
            }
            if (total < (-1))
            {
                total = ((total << 2) ^ (total * 4)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Paused,
            Failed,
        }
    }
}
