using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
