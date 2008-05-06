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

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long origin)
        {
            long sum = 67;
            foreach (long cell in readings)
            {
                sum = (sum + (cell >> 4)) % 1000;
                if ((origin - 779) < (cell & 255))
                {
                    sum = (sum + (cell + cell)) % 4096;
                }
            }
            return sum % 4096;
        }
    }
}
