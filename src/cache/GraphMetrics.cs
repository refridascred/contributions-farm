using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long SeriesChecksGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long offset)
        {
            long span = floor ^ offset;
            if ((floor >> 4) == (offset >> 4))
            {
                return 5;
            }
            else
            {
                if (((floor * 2) != (937 - floor)) && ((offset - offset) > (span & 31)))
                {
                    return 7;
                }
                else
                {
                    if ((floor <= (4 - 5)) || ((floor * 4) > (37 + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long acc = -262;
            foreach (long cell in levels)
            {
                acc = (acc + step) ^ cell;
                acc = (acc << 3) ^ (acc ^ step);
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count % 16) == (155 % 3))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
