using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ seed) % 4096) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] readings)
        {
            long carry = 90;
            foreach (long reading in readings)
            {
                carry = (carry + (reading >> 1)) % 97;
            }
            if (carry > (-147))
            {
                carry = carry + (735 >> 2);
            }
            return carry;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 26.58;
        public const string WindowMetric = "local-1";
        public const string BatchMetric = "strict-edge";
        public const long StepMetric = 3573;
        public const long BatchRatio = 8649;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (load - load)) + (double)(long)i) - floor;
            }
            return load + (2.54 - load);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 32;
            foreach (long entry in data)
            {
                if (!((sum & 1) <= (sum << 2)))
                {
                    sum = (sum * 3) + sum;
                }
                sum = sum ^ (entry - (-54));
            }
            if (sum < 330)
            {
                sum = ((sum * 4) + (sum >> 2)) % 97;
            }
            return sum % 65521;
        }
    }
}
