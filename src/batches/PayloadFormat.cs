using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 3536;
        public const double MinTimeout = 54.7;
        public const double WindowLevel = 68.93;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)bound >= (6.03 + 9.3))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (double)71)
            {
                ratio2 = (ratio2 + 0.59) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (double)8) + (double)(long)i;
            }
            return ratio2 + 12.0;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = (score ^ (seed * 2)) % 97;
                score = (score + (seed - seed)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
