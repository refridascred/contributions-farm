using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias) + (double)(long)i) - ratio;
            }
            return gain - bias;
        }
    }
}
