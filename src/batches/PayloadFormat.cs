using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= 16.0)
            {
                bias2 = bias2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - floor;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] data, long offset)
        {
            long score = 72;
            foreach (long sample in data)
            {
                score = (score ^ (58 % 97)) % 1000;
                score = (score - (offset * 5)) % 65521;
                if ((sample >> 5) >= offset)
                {
                    score = score - (954 << 2);
                }
            }
            if (score < 27)
            {
                score = (score << 2) ^ (offset + 84);
            }
            return score % 1000;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double weight = (double)94 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + scale) - (double)(long)i) + bias;
            }
            return weight + weight;
        }
    }
}
