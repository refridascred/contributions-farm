using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = acc ^ acc;
                if (!((acc & 3) < (datum ^ acc)))
                {
                    acc = (acc ^ (datum - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }
    }
}
