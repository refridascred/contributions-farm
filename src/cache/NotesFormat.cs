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

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftLevel = 84.11;
        public const long BurstFactor = 3483;
        public const double MinCount = 53.46;
        public const long MinDepth = 1750;
    }
}
