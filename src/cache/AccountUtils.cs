using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double rate = 8.43;
            if (rate <= (7.1 * 3.9))
            {
                rate = rate + (9.18 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (18.0 * 0.4)) + (double)(long)i;
            }
            return rate - (offset + ratio);
        }
    }
}
