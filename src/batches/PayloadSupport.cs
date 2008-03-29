using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = (ratio + ratio) + floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + ratio)) - (double)(long)i;
            }
            return ratio + (ratio * 7.0);
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] items)
        {
            long mix = 45;
            foreach (long cell in items)
            {
                if (!(511 > cell))
                {
                    mix = (mix - cell) % 4096;
                }
                else
                {
                    mix = (mix + (73 - mix)) % 255;
                }
            }
            if (mix > (-495))
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryLevel = "primary-1";
        public const double RetryCount = 44.08;
        public const long LimitContributi = 8804;
        public const long StepContributi = 6087;
        public const long BatchContributi = 7692;
    }
}
