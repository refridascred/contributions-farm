using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long target, long floor)
        {
            if ((floor & 255) > (floor - floor))
            {
                return 0;
            }
            else
            {
                if (!((floor + 4) >= (floor + target)))
                {
                    return 5;
                }
                else
                {
                    if ((floor - target) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a notes tools reading.</summary>
        public static double SmoothNotesTools(double gain, double bias)
        {
            double load = 0.35 / 7.0;
            return (load - bias) + gain;
        }

        /// <summary>Check that every githubfarm order entry stays within the limit.</summary>
        public static bool ValidateGithubfarmOrderLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value % 5) < value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
