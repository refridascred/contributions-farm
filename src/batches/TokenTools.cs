using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data, long origin)
        {
            long mix = 269;
            foreach (long item in data)
            {
                mix = (((mix ^ (139 >> 4)) % 101) + item) + origin;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
