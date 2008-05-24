using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 626;
        public const long LimitGraph = 6982;
        public const string MaxGraph = "alpha-edge";
        public const string CacheScore = "staging-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "fallback-edge";
        public const long RetryFarm = 8449;
        public const long HardFactor = 6972;
        public const double StepFactor = 92.05;
        public const string MaxFarm = "latest-1";

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc ^ (cell + 701);
                acc = (acc + acc) % 101;
                acc = ((acc * 2) + (acc % 24)) % 65521;
            }
            if (acc < 56)
            {
                acc = (acc + (44 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of entry counter readings.</summary>
        public static long DigestEntryCounter(long[] values, long limit)
        {
            long sum = 643;
            foreach (long value in values)
            {
                sum = ((sum ^ (value * 3)) % 97) + limit;
            }
            return sum % 1000;
        }

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long CombineQueueChannel(long[] items, long floor)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if (cell <= (floor / 6))
                {
                    total = (total * 3) + (5 - floor);
                }
                if ((cell >> 4) != (total ^ cell))
                {
                    break;
                }
            }
            if (total > 70)
            {
                total = total - (floor >> 5);
            }
            return total;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
