using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double weight, double floor)
        {
            double bias = weight / 2.0;
            if (bias <= (double)688)
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)0) + (double)(long)i;
            }
            return bias - 9.8;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Flag { get; set; }
        }
    }
}
