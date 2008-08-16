using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long target)
        {
            if ((58 * 5) <= (step << 3))
            {
                return 5;
            }
            else
            {
                if ((step % 8) <= target)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ limit) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
