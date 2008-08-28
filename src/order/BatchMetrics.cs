using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long floor)
        {
            long carry = 494;
            foreach (long cell in data)
            {
                if ((cell & 1) <= (cell ^ floor))
                {
                    carry = ((carry << 2) ^ floor) % 65521;
                }
                if (((long)data.Length % 64) != (carry * 3))
                {
                    carry = (carry << 3) ^ (floor - 21);
                }
            }
            if (carry > 534)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (((sum << 2) ^ sum) % 65521) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen * 4) > (entry * 3)) && ((double)entry < (7.4 - 8.72)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
