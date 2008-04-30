using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 3119;
        public const double StepContext = 9.82;
        public const long BurstRatio = 2043;

        /// <summary>Rank filter order input into a small class.</summary>
        public static long GradeFilterOrder(long floor, long target)
        {
            long lane = floor + target;
            if ((floor - floor) > (4 - lane))
            {
                return 0;
            }
            else
            {
                if ((target << 2) < 2)
                {
                    return 2;
                }
                else
                {
                    if (!((target - floor) >= (floor & 255)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long CountStatsContributiGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count > (count ^ sample)) || (count >= (sample >> 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + reading) == (count - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
