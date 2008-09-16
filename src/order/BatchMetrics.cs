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

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series)
        {
            long anchor = 328;
            foreach (long value in series)
            {
                if ((value >> 1) <= value)
                {
                    anchor = anchor ^ ((-43) / 9);
                }
                if ((double)value == (14.0 + 8.0))
                {
                    break;
                }
            }
            return anchor % 65521;
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
