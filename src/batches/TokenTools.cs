using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + entry) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
