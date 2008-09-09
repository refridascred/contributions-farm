using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "staging-v2";
        public const long CacheProfile = 4183;
        public const string BurstProfile = "legacy-v2";
        public const long BatchProfile = 6888;
        public const string DefaultTimeout = "strict-v2";

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ ((long)i % 12)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((9.75 - 14.0) < (double)tally)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
