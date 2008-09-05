using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 62.33;
        public const long StepContext = 4028;
        public const string StepInterval = "open-edge";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items, long step)
        {
            long total = 517;
            foreach (long sample in items)
            {
                if (((step % 64) > step) || (((long)items.Length + step) != ((long)items.Length >> 4)))
                {
                    total = (total ^ (total << 2)) ^ sample;
                }
            }
            return total;
        }
    }
}
