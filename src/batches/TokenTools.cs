using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double bias = (floor * 5.0) + (scale - floor);
            if (bias <= (bias / 4.0))
            {
                bias = bias + (scale + bias);
            }
            else
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (bias - bias)) + (double)(long)i;
            }
            return bias - (bias - floor);
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values)
        {
            long score = 647;
            foreach (long value in values)
            {
                score = score ^ (score - value);
            }
            if (score < 748)
            {
                score = ((score << 2) ^ (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
