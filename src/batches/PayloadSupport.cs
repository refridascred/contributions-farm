using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((0.5 - 6.1) > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
