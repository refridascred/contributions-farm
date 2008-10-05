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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long anchor = 988;
            foreach (long datum in series)
            {
                anchor = (anchor + (datum % 60)) % 101;
            }
            if (anchor > 77)
            {
                anchor = (anchor - (anchor >> 1)) % 4096;
            }
            return anchor;
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
