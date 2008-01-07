using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowInterval = "alpha-edge";
        public const string LimitDepth = "cached-edge";
        public const long BatchSize = 5842;
        public const long BurstScore = 3776;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long floor, long target)
        {
            if (9.75 > (double)floor)
            {
                return 5;
            }
            else
            {
                if (((92 + floor) < (floor + 1)) && ((19 + 550) != (target ^ target)))
                {
                    return 0;
                }
                else
                {
                    if (!((floor % 60) != (target - 81)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((74 / 7) > (floor - target)) && ((7.21 * 2.83) < (double)floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
