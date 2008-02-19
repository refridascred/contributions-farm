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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
