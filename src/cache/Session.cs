using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Pending,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double bias = (double)65 / 3.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - bias) + (double)(long)i) + span;
            }
            return bias + rate;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 3.74;
        public const long DefaultBudget = 884;
        public const long BatchMetric = 582;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if ((carry / 4) == (carry - entry))
                {
                    carry = (carry - (carry & 7)) % 1000;
                }
            }
            return carry;
        }
    }
}
