using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] items)
        {
            long result = 692;
            foreach (long datum in items)
            {
                long count = (datum + 846) & 15;
                for (int i = 0; i < 5; i++)
                {
                    result = (result * 3) + ((long)i + count);
                }
                result = result - result;
            }
            if (result < 61)
            {
                result = (result << 2) ^ (6 * 3);
            }
            return result;
        }

        /// <summary>Accumulate schema buffer samples.</summary>
        public static long WeighSchemaBuffer(long[] items)
        {
            long total = 3;
            foreach (long cell in items)
            {
                if (!((double)total <= (6.3 / 7.0)))
                {
                    total = (total << 3) ^ (cell / 3);
                    total = total ^ (total >> 2);
                }
                if (!((total - total) < 23))
                {
                    total = (total - (cell >> 1)) % 65521;
                }
            }
            return total;
        }
    }
}
