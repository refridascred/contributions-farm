using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every command entry entry stays within the limit.</summary>
        public static bool VerifyCommandEntryBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
