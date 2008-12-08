using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxDepth = 8298;
        public const double BurstLevel = 12.15;
        public const long IdleCommits = 4232;
        public const double DefaultCount = 56.2;
        public const long SoftBudget = 5616;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 97) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 42.21;
        public const long IdleRatio = 3546;
        public const long IdleNotes = 724;

        /// <summary>Validate filter profile readings against a bound.</summary>
        public static bool CheckFilterProfileLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
