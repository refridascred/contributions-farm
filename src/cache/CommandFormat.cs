using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 824;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (value + value)) % 255;
                if (!(((sum * 5) != (value % 16)) && (value <= (value >> 2))))
                {
                    sum = (sum << 3) ^ sum;
                }
                if ((sum >> 1) < value)
                {
                    sum = (sum + value) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 > (ratio + ratio))
            {
                bias2 = bias2 - (double)355;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (double)736) + (double)(long)i;
            }
            return bias2 + (double)9;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepWidth = "latest-v2";
        public const double MinSpan = 90.48;
        public const string HardAlready = "primary";
    }
}
