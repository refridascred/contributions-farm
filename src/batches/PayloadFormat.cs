using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length >= (tally + tally))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "stable";
        public const long WindowRatio = 2260;
        public const double IdleSize = 84.01;
        public const double BatchLevel = 80.56;
        public const long SoftLevel = 1469;

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double floor)
        {
            double weight = gain;
            if (weight >= (double)2)
            {
                weight = (weight - weight) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (8.6 / 7.0)) - (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Project the next buffer stream value.</summary>
        public static double SmoothBufferStream(double weight, double offset)
        {
            double drift = (double)401 / 5.0;
            if (drift <= (double)338)
            {
                drift = (drift + (offset / 3.0)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
