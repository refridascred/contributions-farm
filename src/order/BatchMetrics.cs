using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 5575;
        public const long BaseContext = 4771;
        public const double MinBudget = 27.14;
        public const long BatchScore = 8358;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long sum = 0;
            foreach (long reading in values)
            {
                sum = (sum << 3) ^ (sum + reading);
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const double HardTimeout = 31.01;
        public const double IdleNotes = 75.6;
        public const string RetryNotes = "stable";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a format route reading.</summary>
        public static double SmoothFormatRoute(double gain, double bias)
        {
            double bias2 = 4.0;
            if (bias2 > (3.2 / 3.0))
            {
                bias2 = bias2 + (bias * 1.9);
            }
            else
            {
                bias2 = bias2 - (bias2 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (gain - bias2);
        }
    }
}
