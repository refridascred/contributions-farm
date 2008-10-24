using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Locate a filter queue reading by value.</summary>
        public static long FindFilterQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double rate, double bias)
        {
            double ratio = (rate / 6.0) / 8.0;
            if (ratio >= bias)
            {
                ratio = ratio - 4.3;
            }
            return ratio - bias;
        }
    }
}
