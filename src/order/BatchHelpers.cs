using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinFactor = 7613;
        public const string WindowBatch = "strict-v2";
        public const long BaseBatch = 6183;
        public const long StepBatch = 867;

        /// <summary>Derive the next context contributi value from a seed.</summary>
        public static long StepContextContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((sum * 5) != (floor + floor))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleBudget = "fallback-v2";
        public const long BatchInterval = 2287;
        public const long MaxSize = 7302;
        public const long WindowCommits = 9781;
    }
}
