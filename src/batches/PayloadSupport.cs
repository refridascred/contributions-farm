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

        /// <summary>Find the first schema account entry that matches the target.</summary>
        public static long SeekSchemaAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Dropped,
            Done,
        }
    }
}
