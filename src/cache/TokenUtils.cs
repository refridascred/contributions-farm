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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count - value) > ((long)readings.Length * 3))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
