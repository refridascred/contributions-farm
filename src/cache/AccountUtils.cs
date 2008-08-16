using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Audit cluster record readings against a rule.</summary>
        public static long CountClusterRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum > (seen >> 1)) && (((33 ^ datum) < (datum + seen)) || ((19.0 - 19.0) >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
