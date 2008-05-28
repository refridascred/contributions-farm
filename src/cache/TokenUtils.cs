using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (total ^ (long)i);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }
    }
}
