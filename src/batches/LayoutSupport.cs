using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 8725;
        public const long IdleLevel = 364;
        public const long LimitStream = 4103;

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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
