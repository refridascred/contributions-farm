using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((4 + 5) >= (entry >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Done,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long seed)
        {
            if (44 > seed)
            {
                return 5;
            }
            else
            {
                if (seed >= (offset - offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen % 7) < 604)
                {
                    seen = ((seen + 3) ^ value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] items)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + (74 << 3)) % 101) + (long)i;
                    carry = (carry - (carry - carry)) % 255;
                }
                carry = ((carry << 3) ^ 841) % 255;
                if ((8 ^ sample) < (carry ^ sample))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
