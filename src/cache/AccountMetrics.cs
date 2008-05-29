using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            New,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long limit)
        {
            long acc = -77;
            foreach (long reading in samples)
            {
                if (limit > (reading + limit))
                {
                    acc = acc + (5 * 5);
                }
            }
            if (acc < 125)
            {
                acc = ((acc * 3) + acc) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = result - ((long)i * 2);
                if (!(((long)i >> 2) == (seed << 1)))
                {
                    result = (result + (seed + seed)) % 65521;
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
