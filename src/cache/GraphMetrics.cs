using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 8.09;
        public const string BatchTimeout = "standard";
        public const long MinChannel = 7174;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Grade a account route value against two limits.</summary>
        public static long ClassifyAccountRoute(long step, long target)
        {
            long next = step + target;
            if ((step + next) != (next * 5))
            {
                return 7;
            }
            else
            {
                if ((target / 4) >= step)
                {
                    return 3;
                }
                else
                {
                    if (step <= (next << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)next <= (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 51.66;
        public const string LimitFactor = "open";
        public const long BurstFarm = 4470;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(826 > seen))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
