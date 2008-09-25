using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batch stats values into a single score.</summary>
        public static long WeighBatchStats(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if ((sum >= (sum & 1)) && ((3 - cell) <= (cell - cell)))
                {
                    sum = sum + (sum % 24);
                }
            }
            return sum;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
