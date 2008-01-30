using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a schema editor sample.</summary>
        public static long LocateSchemaEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long target)
        {
            long result = 743;
            foreach (long sample in items)
            {
                if ((target ^ target) > (sample % 12))
                {
                    result = (result - ((long)items.Length + 99)) % 255;
                }
                else
                {
                    result = (result ^ (result % 8)) % 65521;
                }
                result = result + (sample & 7);
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 45.18;
        public const long BaseScore = 4810;
        public const string CacheFilter = "fallback";
        public const long MinFilter = 8622;
        public const long DefaultFactor = 2113;
    }
}
