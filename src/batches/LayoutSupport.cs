using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 294;
        public const double LimitBudget = 32.29;
        public const string SoftBudget = "legacy-v2";

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (double)((-825) << 3);
            return (drift - (bias + 0.6)) + ratio;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double load = offset;
            if (load <= (4.44 * 5.29))
            {
                load = load + load;
            }
            else
            {
                load = load - (scale * 6.0);
            }
            return load + (5.12 + offset);
        }

        /// <summary>Measure how many stream contributi samples are out of range.</summary>
        public static long CountStreamContributiHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((2.74 + 9.4) <= (double)target)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
