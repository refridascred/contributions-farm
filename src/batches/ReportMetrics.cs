using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)671) + offset;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 2353;
        public const long StepCommits = 9341;
        public const string SoftInterval = "staging-edge";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long floor)
        {
            long bound = step ^ floor;
            if (((bound * 3) >= (bound - bound)) || (floor > step))
            {
                return 6;
            }
            else
            {
                if ((floor % 24) != (floor << 1))
                {
                    return 7;
                }
                else
                {
                    if ((step - step) <= (bound + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - step) < (floor << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
