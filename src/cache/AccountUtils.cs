using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double mean = gain;
            if (mean > (span - mean))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean + 6.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - 5.21;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinSpan = 95.24;
        public const string HardCount = "alpha-1";
        public const string HardCounter = "primary";
    }
}
