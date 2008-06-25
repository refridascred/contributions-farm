using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = (sum + (datum / 9)) % 4096;
                if ((sum % 7) <= (datum + datum))
                {
                    sum = (sum << 2) ^ datum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "latest-1";
        public const double BurstInterval = 92.63;
        public const long DefaultLevel = 4510;

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double floor)
        {
            double rate2 = (double)((-1) & 127);
            if (rate2 <= (double)92)
            {
                rate2 = rate2 + (double)21;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate) - (double)(long)i;
            }
            return rate2 - floor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double ratio = offset * 3.0;
            if (ratio <= (3.0 / 4.0))
            {
                ratio = ratio - (ratio + ratio);
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (1.0 / 4.0);
        }
    }
}
