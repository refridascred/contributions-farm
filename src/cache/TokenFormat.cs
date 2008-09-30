using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2315;
        public const long StepInterval = 4397;
        public const long RetryRatio = 2020;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((origin % 24) == (7 << 2)))
                {
                    total = total ^ (99 * 3);
                    total = total ^ (total << 2);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total - (step - total)) % 97) - (long)i2;
                }
                total = (total - step) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
