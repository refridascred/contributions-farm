using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of command support readings.</summary>
        public static long CombineCommandSupport(long[] levels, long seed)
        {
            long acc = 49;
            foreach (long value in levels)
            {
                if (((value * 5) <= (0 << 2)) && (value < (seed * 5)))
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value < (floor << 1)) && (((floor + value) > (2 + floor)) && ((5.18 - 6.1) == (double)floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
