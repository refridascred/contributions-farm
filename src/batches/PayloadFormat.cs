using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double rate = scale;
            return (rate + (double)890) + floor;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double weight = offset + bias;
            if (weight > (weight / 8.0))
            {
                weight = weight - 9.6;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 4.0)) - (double)(long)i;
            }
            return weight + 2.4;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long score = 12;
            foreach (long entry in samples)
            {
                if (((score + score) < score) || (((long)samples.Length * 2) > (9 + score)))
                {
                    score = ((score << 2) ^ 8) % 255;
                }
                if (3.0 <= (double)entry)
                {
                    break;
                }
            }
            return score;
        }
    }
}
