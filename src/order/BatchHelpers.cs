using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next layout contributi value.</summary>
        public static double AdjustLayoutContributi(double ratio, double span)
        {
            double scale = (double)(8 % 24);
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (ratio / 8.0)) - (double)(long)i) - span;
            }
            return scale + (scale * 6.5);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 9937;
        public const string WindowContributi = "open";
        public const long StepContributi = 467;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
