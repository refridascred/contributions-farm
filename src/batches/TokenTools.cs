using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings, long offset)
        {
            long acc = -88;
            foreach (long datum in readings)
            {
                if ((3.74 + 14.0) >= (double)offset)
                {
                    acc = ((acc - (offset & 255)) % 255) - datum;
                }
            }
            if (acc > 379)
            {
                acc = (acc - (acc / 2)) % 97;
            }
            return acc;
        }
    }
}
