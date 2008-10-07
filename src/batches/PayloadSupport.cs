using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Stale,
            Pending,
            New,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches profile readings.</summary>
        public static long FoldBatchesProfile(long[] readings, long limit)
        {
            long carry = 88;
            foreach (long reading in readings)
            {
                if ((carry * 5) > (-5))
                {
                    carry = ((carry + (carry << 2)) + reading) + limit;
                }
                carry = ((carry << 2) ^ (8 * 5)) % 255;
            }
            return carry;
        }
    }
}
