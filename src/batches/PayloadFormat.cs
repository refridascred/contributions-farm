using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double rate = (6.12 / 8.0) * 9.5;
            if (rate >= 3.32)
            {
                rate = (rate + (ratio / 8.0)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (rate / 6.0);
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
