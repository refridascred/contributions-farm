using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double mean = (double)(392 >> 3);
            if (mean < (gain - mean))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Derive the next metric command value from a seed.</summary>
        public static long SeriesMetricCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)limit == (double)865)
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                    continue;
                }
                carry = ((carry << 2) ^ (18 - limit)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the entry cluster series from a seed.</summary>
        public static long StepEntryCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total + ((long)i & 15)) ^ (long)i2;
                }
                total = ((total << 3) ^ total) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Stale,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 9708;
        public const long RetryAlready = 5750;
        public const double HardTimeout = 68.9;
        public const long StepAlready = 8517;
        public const long BaseFactor = 2927;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
