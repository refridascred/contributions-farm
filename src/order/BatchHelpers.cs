using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long state = 68;
            foreach (long item in levels)
            {
                if ((double)origin < (double)8)
                {
                    state = ((state << 2) ^ (95 - origin)) ^ item;
                }
            }
            if (state < (-77))
            {
                state = ((state << 3) ^ (617 & 63)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSize = 7206;
        public const long MaxSize = 3286;
        public const long MinFactor = 151;
    }
}
