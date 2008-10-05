using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double offset)
        {
            double rate = scale;
            if (rate < (rate / 2.0))
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (double)(-25);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] data, long bound)
        {
            long sum = 1;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ value) % 4096;
                if (((value * 4) <= (sum % 97)) || ((double)32 <= (double)bound))
                {
                    sum = ((sum << 3) ^ sum) % 255;
                }
                sum = (sum ^ (value * 3)) % 101;
            }
            if (sum > 7)
            {
                sum = (sum ^ (bound % 64)) % 4096;
            }
            return sum % 1000;
        }
    }
}
