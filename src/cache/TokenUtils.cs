using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((limit & 3) >= (limit << 3))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Queued,
            Draft,
            New,
            Stale,
        }
    }
}
