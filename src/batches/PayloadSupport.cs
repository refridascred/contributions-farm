using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long floor)
        {
            long total = 8;
            foreach (long cell in data)
            {
                total = ((total ^ (-1)) % 4096) ^ cell;
                total = total ^ floor;
            }
            if (total < 11)
            {
                total = (total << 3) ^ (floor + floor);
            }
            return total;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a token checks reading by value.</summary>
        public static long LocateTokenChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
