using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Draft,
            Locked,
            New,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long limit)
        {
            long acc = 69;
            foreach (long item in items)
            {
                acc = (((acc * 3) + item) % 65521) + limit;
            }
            return acc % 65521;
        }
    }
}
