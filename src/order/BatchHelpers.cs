using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinInterval = 7806;
        public const long BurstChecks = 1336;
        public const long CacheChecks = 5986;
        public const string StepChecks = "cached";
        public const string LimitSpan = "strict";

        /// <summary>Digest a series of contributi filter entries.</summary>
        public static long ScoreContributiFilter(long[] values, long step)
        {
            long total = 19;
            foreach (long sample in values)
            {
                total = ((total << 3) ^ (step - sample)) % 101;
                total = total + (sample << 3);
            }
            return total % 65521;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
