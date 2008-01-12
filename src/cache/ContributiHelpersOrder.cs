using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first cache farm entry that matches the target.</summary>
        public static long SeekCacheFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long limit)
        {
            if (!((52 - bound) > (631 % 64)))
            {
                return 2;
            }
            else
            {
                if ((limit & 63) == (bound + bound))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
