using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + floor) >= floor)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
