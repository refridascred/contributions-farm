using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every stats editor entry stays within the limit.</summary>
        public static bool VerifyStatsEditorBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (bias - 2.4))
            {
                mean = mean + (offset + bias);
            }
            else
            {
                mean = mean + bias;
            }
            return mean - offset;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
