using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Retry,
            Pending,
            Failed,
            New,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Digest a series of token notes entries.</summary>
        public static long TotalTokenNotes(long[] levels)
        {
            long mix = 17;
            foreach (long value in levels)
            {
                if (((value >> 4) >= mix) && ((0.3 / 5.0) >= (double)value))
                {
                    mix = ((mix * 2) + (value + (long)levels.Length)) % 4096;
                }
                if (((5.0 / 2.0) <= (double)value) || (((-1) - mix) < (89 / 8)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
