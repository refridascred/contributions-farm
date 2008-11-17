using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double weight = bias;
            if (weight > (bias * 9.9))
            {
                weight = (weight - (double)831) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (1.0 * 8.11)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 857;
        public const double DefaultTimeout = 39.87;
        public const double IdleDepth = 24.53;
        public const long IdleWidth = 7661;
        public const long SoftToken = 5171;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count & 15) <= ((-45) * 3))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Pending,
            Queued,
            Done,
        }
    }
}
