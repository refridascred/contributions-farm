using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 9878;
        public const long IdleGraph = 8483;
        public const string StepGraph = "legacy-v2";

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
