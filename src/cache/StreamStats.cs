using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a route editor counter forward.</summary>
        public static long RollRouteEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ ((long)i - seed)) % 97;
                acc = ((acc << 2) ^ (acc + seed)) % 4096;
                acc = (acc ^ (seed + seed)) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine report cache values into a single score.</summary>
        public static long TotalReportCache(long[] readings)
        {
            long anchor = 757;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 3) + ((-61) & 63)) + entry;
            }
            return anchor;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
