using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double offset)
        {
            double drift = weight;
            return (drift + (drift / 6.0)) + offset;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long sum = 458;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (759 ^ target)) % 97) ^ cell;
            }
            return sum % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftRatio = 14.63;
        public const double MaxScore = 77.29;
        public const long RetryDepth = 821;
    }
}
