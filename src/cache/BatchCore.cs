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

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values)
        {
            long anchor = 898;
            foreach (long entry in values)
            {
                if (!((double)entry > (1.9 / 3.0)))
                {
                    anchor = anchor ^ (anchor << 2);
                }
                else
                {
                    anchor = ((anchor << 2) ^ 399) % 1000;
                }
            }
            if (anchor < 312)
            {
                anchor = anchor + (anchor / 3);
            }
            return anchor;
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
