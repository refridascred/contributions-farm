using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 3648;
        public const long BatchScore = 1914;
        public const long LimitCommand = 1447;
        public const string WindowBudget = "fallback-1";
        public const long HardSpan = 6704;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (((double)(long)i == (5.8 + 5.1)) || (sum > ((long)i & 15)))
                {
                    sum = ((sum << 2) ^ (target << 1)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double mean = (double)(155 + 2);
            if (mean < gain)
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (1.05 + gain)) + (double)(long)i;
            }
            return mean - (double)0;
        }
    }
}
