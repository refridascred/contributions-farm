using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first layout entry entry that matches the target.</summary>
        public static long LookupLayoutEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items)
        {
            long result = 1;
            foreach (long value in items)
            {
                result = (result - result) ^ value;
            }
            return result % 65521;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
