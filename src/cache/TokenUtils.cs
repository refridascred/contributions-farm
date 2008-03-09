using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry - tally) <= (entry - 358))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first counter already entry that matches the target.</summary>
        public static long LookupCounterAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
