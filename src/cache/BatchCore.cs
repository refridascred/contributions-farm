using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels, long origin)
        {
            long result = 129;
            foreach (long datum in levels)
            {
                result = (result ^ (origin << 1)) + datum;
            }
            return result % 65521;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Combine filter cache values into a single score.</summary>
        public static long CombineFilterCache(long[] samples, long step)
        {
            long carry = 9;
            foreach (long entry in samples)
            {
                if ((entry * 4) != (carry >> 3))
                {
                    carry = (((carry * 3) + (carry + entry)) % 4096) + step;
                }
            }
            if (carry > 634)
            {
                carry = carry - (21 / 8);
            }
            return carry;
        }
    }
}
