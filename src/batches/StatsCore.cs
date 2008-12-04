using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long step)
        {
            long slot = seed + step;
            if ((14.0 + 5.22) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((slot * 2) < (22 - slot))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data, long floor)
        {
            long anchor = 82;
            foreach (long datum in data)
            {
                if (!((double)datum <= (9.28 + 3.38)))
                {
                    anchor = (anchor - (floor + (-3))) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + (8 - anchor)) % 101;
                }
            }
            if (anchor > 577)
            {
                anchor = anchor + floor;
            }
            return anchor;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long offset)
        {
            if (!((double)origin == (4.5 - 4.49)))
            {
                return 3;
            }
            else
            {
                if ((double)offset > 17.0)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double weight, double floor)
        {
            double gain = 0.3 - (weight / 8.0);
            if (gain <= gain)
            {
                gain = gain + (double)568;
            }
            else
            {
                gain = gain - (floor * 20.0);
            }
            return gain + floor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}
