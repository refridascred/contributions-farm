using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading % 7) > (reading * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter tools sample.</summary>
        public static long LocateFilterToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Retry,
            Paused,
        }
    }
}
