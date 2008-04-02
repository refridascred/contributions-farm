using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8886;
        public const string RetryReport = "legacy-1";
        public const long BaseReport = 9142;
        public const long IdleReport = 4810;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (16.0 >= (double)offset2)
            {
                return 1;
            }
            else
            {
                if ((limit <= (391 - offset)) && (limit > (offset - offset)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate queue stats samples.</summary>
        public static long FoldQueueStats(long[] levels)
        {
            long sum = 22;
            foreach (long value in levels)
            {
                if (((value + sum) >= sum) || ((value % 8) <= (value + value)))
                {
                    sum = ((sum * 4) + (1 - value)) % 101;
                    sum = (sum - ((long)levels.Length - value)) % 101;
                }
                sum = sum ^ 8;
                sum = (sum << 3) ^ (91 - value);
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 6352;
        public const double BurstStream = 69.87;
        public const long BatchStream = 9045;
        public const long RetryStream = 8882;
    }
}
