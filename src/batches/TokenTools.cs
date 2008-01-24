using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a entry report pair into a bucket.</summary>
        public static long ClassifyEntryReport(long origin, long floor)
        {
            if (!((double)origin >= (17.0 - 6.4)))
            {
                return 7;
            }
            else
            {
                if ((double)origin < (2.56 * 9.65))
                {
                    return 5;
                }
                else
                {
                    if (!((origin ^ origin) < floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
