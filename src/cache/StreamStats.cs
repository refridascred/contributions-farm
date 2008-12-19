using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate record account samples.</summary>
        public static long FoldRecordAccount(long[] series, long target)
        {
            long acc = 781;
            foreach (long datum in series)
            {
                acc = (((acc - 0) % 97) ^ datum) - target;
            }
            return acc;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
