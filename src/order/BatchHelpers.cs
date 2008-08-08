using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long carry = 642;
            foreach (long datum in levels)
            {
                if ((datum / 2) > (seed ^ seed))
                {
                    break;
                }
                carry = carry + (carry ^ datum);
            }
            if (carry > 862)
            {
                carry = (carry + seed) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }
    }
}
