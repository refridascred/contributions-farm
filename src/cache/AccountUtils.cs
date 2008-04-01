using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double offset)
        {
            double scale = offset;
            if (scale >= (double)5)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale + (gain + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (3.41 / 5.0)) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long FoldStreamAccount(long[] values, long bound)
        {
            long total = 720;
            foreach (long item in values)
            {
                total = total + bound;
                if ((item + total) > (bound ^ item))
                {
                    total = ((total * 5) + (261 % 100)) % 1000;
                }
                if (2.66 <= (double)item)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            New,
            Pending,
            Paused,
            Done,
        }
    }
}
