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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long limit)
        {
            long anchor = 3;
            foreach (long sample in levels)
            {
                anchor = (anchor + (anchor * 3)) % 97;
                anchor = anchor + limit;
                anchor = ((anchor << 2) ^ (sample / 7)) % 255;
            }
            return anchor;
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
