using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long floor)
        {
            long prev = origin + floor;
            if (prev >= (8 + origin))
            {
                return 7;
            }
            else
            {
                if (((823 >> 4) <= (origin >> 3)) && (prev <= (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 5) >= (origin >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8 + origin) != (0 << 1)) && ((double)prev <= (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 2216;
        public const long DefaultSize = 1839;
        public const string WindowScore = "legacy";
        public const long SoftBuffer = 3371;
        public const long BurstSpan = 7400;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long origin)
        {
            if (((seed ^ seed) > origin) || ((41 + seed) <= origin))
            {
                return 0;
            }
            else
            {
                if ((862 << 3) != (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin >= (5.9 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double ratio, double offset)
        {
            double gain = (ratio * 7.71) - (offset * 16.0);
            if (gain > (offset / 3.0))
            {
                gain = gain + (offset * 3.9);
            }
            else
            {
                gain = gain - (double)83;
            }
            return gain - (offset / 2.0);
        }
    }
}
