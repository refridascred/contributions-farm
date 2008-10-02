using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a notes window value against two limits.</summary>
        public static long BucketNotesWindow(long target, long bound)
        {
            if ((bound >> 2) != (791 - target))
            {
                return 6;
            }
            else
            {
                if ((bound & 31) > (2 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((691 + 753) >= (bound % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseRatio = 1217;
        public const double DefaultWidth = 43.07;
        public const string HardContext = "primary-1";
        public const string MaxContext = "cached-1";

        /// <summary>Match up tools filter samples.</summary>
        public static long CompareToolsFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double scale = (16.0 - offset) - bias;
            return scale + offset;
        }

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long GradeBatchCommand(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (!((diff + seed) < seed2))
            {
                return 4;
            }
            else
            {
                if ((seed2 << 1) > (diff - diff))
                {
                    return 8;
                }
                else
                {
                    if (((seed2 + seed) > diff) && ((seed % 64) == (seed2 ^ diff)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
