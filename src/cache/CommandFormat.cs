using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double offset)
        {
            double bias = gain;
            if (bias > (double)(-178))
            {
                bias = bias - (double)94;
            }
            return bias + offset;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double drift = (bias2 / 5.0) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 0.74)) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
