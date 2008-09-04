using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ seed) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double scale = 9.02;
            if (scale >= floor)
            {
                scale = (scale + floor) - bias;
            }
            else
            {
                scale = scale + (double)76;
            }
            return scale + (double)532;
        }
    }
}
