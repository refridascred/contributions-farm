using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 34.58;
        public const long MinBudget = 6150;
        public const double LimitCache = 78.18;
        public const string StepWidth = "latest-v2";

        /// <summary>Find the first format report entry that matches the target.</summary>
        public static long SeekFormatReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double ratio = (bias - 7.26) + (bias / 9.0);
            return (ratio + bias) + weight;
        }
    }
}
