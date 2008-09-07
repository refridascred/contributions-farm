using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Draft,
            Idle,
            Closed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                carry = (carry << 2) ^ (datum << 1);
            }
            if (carry > (-653))
            {
                carry = (carry * 3) + (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
