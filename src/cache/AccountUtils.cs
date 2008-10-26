using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mix = 601;
            foreach (long value in levels)
            {
                if (value >= (value & 31))
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
            }
            return mix;
        }
    }
}
