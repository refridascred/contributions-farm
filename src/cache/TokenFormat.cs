using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > (bias * 9.47))
            {
                gain = gain - (5.0 + bias2);
            }
            else
            {
                gain = gain + (bias + bias2);
            }
            return gain - (double)88;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
