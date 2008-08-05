using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] items, long bound)
        {
            long score = -40;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    long cur = (score - bound) ^ (sample >> 2);
                    score = score + (cur & 63);
                }
                score = (score + (bound - score)) % 255;
            }
            if (score > (-324))
            {
                score = (score - (bound & 127)) % 97;
            }
            return score % 97;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double weight, double offset)
        {
            double bias = (double)20;
            if (bias >= (double)35)
            {
                bias = (bias - offset) + weight;
            }
            return bias - offset;
        }
    }
}
