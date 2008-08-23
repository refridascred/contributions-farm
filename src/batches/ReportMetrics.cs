using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleBudget = 7604;
        public const string DefaultRecord = "local-edge";
        public const long SoftRecord = 8865;
        public const long DefaultLevel = 1664;

        /// <summary>Project the next window filter value.</summary>
        public static double ScaleWindowFilter(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= 16.0)
            {
                weight = (weight + (6.8 * 16.0)) - offset;
            }
            return weight - ratio;
        }
    }
}
