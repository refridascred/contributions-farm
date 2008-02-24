using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Digest a series of session route entries.</summary>
        public static long WeighSessionRoute(long[] items, long seed)
        {
            long mix = 769;
            foreach (long entry in items)
            {
                mix = ((mix + entry) % 4096) - seed;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples)
        {
            long state = -68;
            foreach (long datum in samples)
            {
                state = (state ^ datum) % 1000;
                state = (state - (state + state)) % 101;
            }
            if (state < 25)
            {
                state = ((state << 2) ^ (89 - state)) % 255;
            }
            return state % 1000;
        }
    }
}
