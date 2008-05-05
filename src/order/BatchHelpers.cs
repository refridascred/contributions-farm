using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long target)
        {
            long total = 0;
            foreach (long entry in readings)
            {
                if ((18.0 - 9.0) <= (double)total)
                {
                    total = ((total + (total - entry)) % 101) - target;
                }
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
