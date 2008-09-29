using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double bias = (ratio - ratio) * 17.0;
            if (bias >= (offset / 9.0))
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)76) + (double)(long)i;
            }
            return bias - (ratio - bias);
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
