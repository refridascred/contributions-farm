using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long DigestBufferFilter(long[] data)
        {
            long carry = 99;
            foreach (long reading in data)
            {
                carry = carry ^ (carry ^ 73);
                if ((carry + 15) < (reading - carry))
                {
                    carry = (carry + (carry << 3)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (carry + reading)) % 65521;
                }
            }
            if (carry > 872)
            {
                carry = (carry * 3) + (carry >> 1);
            }
            return carry;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter route entries that pass the check.</summary>
        public static long MeasureFilterRouteOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum * 2) < limit)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
