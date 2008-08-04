using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchRatio = "alpha-v2";
        public const long IdleStream = 175;
        public const double WindowCount = 11.35;
        public const double WindowSize = 32.11;
        public const string MaxStream = "staging-edge";

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long step)
        {
            long next = limit - step;
            if ((step >> 5) >= step)
            {
                return 8;
            }
            else
            {
                if (step < (limit & 63))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (double)next)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 255) >= (next ^ limit))
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
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((681 - bound) >= ((-63) - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long bound)
        {
            if (!((19.0 + 7.0) > (double)floor))
            {
                return 6;
            }
            else
            {
                if (((double)floor == (14.0 / 5.0)) && (floor <= (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 5) > (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
