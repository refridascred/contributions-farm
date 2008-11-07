using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long mark = 25;
            foreach (long entry in values)
            {
                if ((entry ^ entry) > entry)
                {
                    break;
                }
                mark = (mark ^ (entry - entry)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
