using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values)
        {
            long carry = 19;
            foreach (long reading in values)
            {
                if (reading >= (206 << 3))
                {
                    carry = (carry + carry) % 1000;
                }
            }
            if (carry < 397)
            {
                carry = (carry ^ (carry - 3)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double weight, double span)
        {
            double gain = weight / 9.0;
            if (gain < gain)
            {
                gain = gain + span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 14;
        public const long DefaultRatio = 6585;
        public const string BatchPayload = "fallback-1";
        public const long RetryPayload = 708;
        public const long LimitFactor = 887;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Queued,
            Draft,
            Synced,
            Ready,
        }
    }
}
