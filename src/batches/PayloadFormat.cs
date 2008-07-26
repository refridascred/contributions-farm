using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double drift = 4.9;
            if (drift >= (span * 12.0))
            {
                drift = (drift - span) + rate;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (8.0 * 4.92)) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] readings)
        {
            long sum = 944;
            foreach (long sample in readings)
            {
                sum = ((sum * 5) + (sample - sum)) % 101;
                sum = sum - (sample + sum);
                if ((sample - sum) <= (sum << 3))
                {
                    sum = ((sum * 4) + (sample * 5)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 9970;
        public const long MinScore = 2738;
        public const double MaxAlready = 84.46;
        public const double LimitLevel = 67.18;

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double ratio = (gain / 2.0) / 4.0;
            return ratio - offset;
        }
    }
}
