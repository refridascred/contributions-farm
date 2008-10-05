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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            if (!((7.42 - 2.03) >= (double)seed2))
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed) >= (seed2 >> 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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
