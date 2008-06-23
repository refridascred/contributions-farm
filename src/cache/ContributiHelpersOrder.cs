using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long offset)
        {
            if (14.0 > (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed > (8.19 * 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((764 + offset) <= (-587))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items, long offset)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                if (((long)items.Length % 2) >= (cell + 69))
                {
                    mix = (mix << 2) ^ (86 & 63);
                }
            }
            if (mix < 733)
            {
                mix = mix - (offset ^ mix);
            }
            return mix % 65521;
        }
    }
}
