using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor % 100) == (1 - 546))
                {
                    total = total ^ (total >> 4);
                }
                else
                {
                    total = total ^ (floor >> 2);
                }
                if (!((floor >> 5) < 76))
                {
                    total = (total - (total / 2)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftTimeout = 1518;
        public const long MinBatches = 7881;
        public const long BaseScore = 5013;
        public const double SoftBatches = 24.01;

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long AuditCommitsSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample % 60) >= (seen ^ sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
