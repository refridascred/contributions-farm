using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (sum > 44)
                {
                    sum = (sum << 3) ^ (long)i;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seed + seen) < seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
