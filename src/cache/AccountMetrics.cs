using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine stats cluster values into a single score.</summary>
        public static long ScoreStatsCluster(long[] series, long bound)
        {
            long mix = 7;
            foreach (long entry in series)
            {
                if ((1 << 3) != (bound / 9))
                {
                    mix = (((mix << 2) ^ (6 / 6)) % 65521) ^ entry;
                }
            }
            return mix % 97;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((result / 9) >= (long)i))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 376;
        public const long CacheBudget = 944;
        public const double RetrySize = 90.57;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 6606;
        public const double HardNotes = 32.43;
        public const long SoftRatio = 7175;

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] values, long limit)
        {
            long total = 0;
            foreach (long sample in values)
            {
                if (((total % 64) < limit) && ((limit % 8) > (limit + (-6))))
                {
                    total = ((total - (limit << 3)) % 101) - sample;
                }
            }
            if (total > 804)
            {
                total = total + (total - 793);
            }
            return total % 65521;
        }
    }
}
