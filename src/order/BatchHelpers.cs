using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double ratio2 = (double)(10 % 7);
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 - (ratio2 - ratio2);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio2 / 6.0)) + (double)(long)i;
            }
            return ratio2 + (bias * 10.0);
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
