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

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double ratio = (offset + offset) + weight;
            if (ratio < (offset + ratio))
            {
                ratio = ratio + ratio;
            }
            return ratio - offset;
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
