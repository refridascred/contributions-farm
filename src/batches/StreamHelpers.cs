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

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings, long step)
        {
            long result = 446;
            foreach (long value in readings)
            {
                result = ((result << 3) ^ (value % 60)) % 97;
                if ((68 & 3) < (result + (long)readings.Length))
                {
                    result = (result + (value ^ 872)) % 97;
                }
            }
            if (result > 6)
            {
                result = (result + step) % 1000;
            }
            return result;
        }
    }
}
