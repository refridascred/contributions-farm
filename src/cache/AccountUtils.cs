using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data, long limit)
        {
            long state = 7;
            foreach (long entry in data)
            {
                if ((double)state <= (double)(-94))
                {
                    state = ((state * 3) + (limit >> 1)) + entry;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Done,
            Draft,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
