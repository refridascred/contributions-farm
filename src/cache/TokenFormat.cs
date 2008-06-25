using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)6) + (double)(long)i) + offset;
            }
            return gain + 9.0;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
