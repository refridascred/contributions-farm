using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long carry = 205;
            foreach (long value in readings)
            {
                carry = (carry - value) % 255;
            }
            if (carry > 119)
            {
                carry = (carry * 5) + (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long origin)
        {
            if ((origin / 8) == (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ 522) > (limit - limit)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double mean = (1.4 / 4.0) / 7.0;
            if (mean >= (double)4)
            {
                mean = ((mean + (6.6 + mean)) + weight) - offset;
            }
            else
            {
                mean = mean + (6.0 / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - 1.11;
        }
    }
}
