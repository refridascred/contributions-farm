using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Idle,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long CountSchemaCommandMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits ^ 24) <= (offset % 97)) || ((offset * 4) <= (110 + 98)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
