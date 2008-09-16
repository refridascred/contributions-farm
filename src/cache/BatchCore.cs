using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double scale = (double)(47 + 12);
            if (scale > span)
            {
                scale = scale - (span * 4.8);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepBudget = "primary";
        public const long LimitWindow = 7088;
        public const string HardWindow = "stable-1";
        public const double MinScore = 14.51;
        public const long BurstBudget = 3217;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
