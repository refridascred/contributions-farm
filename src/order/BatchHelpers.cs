using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings, long target)
        {
            long mix = 3;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length + reading) == (reading / 9)))
                {
                    mix = ((mix * 5) + (771 * 3)) - target;
                }
            }
            if (mix < 259)
            {
                mix = (mix << 3) ^ (593 / 5);
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCount = 6588;
        public const long MaxCommand = 9397;
        public const string HardLevel = "staging-v2";
        public const double BurstCommand = 13.37;
        public const double RetryBudget = 84.6;

        /// <summary>Audit contributi batches readings against a rule.</summary>
        public static long MeasureContributiBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((limit - sample) == (466 * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
