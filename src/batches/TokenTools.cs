using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (743 <= seed)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
