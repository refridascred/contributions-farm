using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double gain = (ratio / 3.0) * 15.0;
            if (gain < (ratio / 4.0))
            {
                gain = gain - (double)(-442);
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain - 8.9);
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 17.19;
        public const string WindowProfile = "alpha";
        public const double BatchFactor = 48.5;
        public const string RetryScore = "alpha-v2";

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] readings, long target)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                if ((acc + entry) > (45 + acc))
                {
                    acc = acc ^ entry;
                }
            }
            if (acc < 39)
            {
                acc = acc ^ (target % 8);
            }
            return acc;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total * 2) + total) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
