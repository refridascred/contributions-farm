using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            New,
            Draft,
        }
    }
}
