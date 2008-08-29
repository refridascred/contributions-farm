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

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long bound)
        {
            long gap = limit + bound;
            if (gap >= bound)
            {
                return 1;
            }
            else
            {
                if (!((double)gap >= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (((6.69 - 3.9) > (double)bound) && ((double)gap < (9.66 - 9.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit >> 2) > (bound + gap)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
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
