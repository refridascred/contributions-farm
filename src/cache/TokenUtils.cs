using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double bias2 = 4.44;
            if (bias2 <= (bias - 5.43))
            {
                bias2 = (bias2 - bias2) + span;
            }
            return bias2 + (double)17;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double mean = (double)65 - (double)41;
            if (mean <= (scale * 6.3))
            {
                mean = (mean - scale) - offset;
            }
            else
            {
                mean = mean - (8.28 - mean);
            }
            return mean - scale;
        }
    }
}
