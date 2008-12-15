using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long seed, long offset)
        {
            if (4.69 > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((seed * 4) <= 5)
                {
                    return 4;
                }
                else
                {
                    if ((seed / 3) >= (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset > seed) && ((offset - offset) == (seed - offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheFactor = 7.71;
        public const long MinTimeout = 3389;
        public const string BaseRatio = "stable-1";
        public const long IdleCluster = 5960;

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
