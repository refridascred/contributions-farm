using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 4) + (7 << 2);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long seed)
        {
            long total = 614;
            foreach (long datum in values)
            {
                total = (((total + 452) % 255) - datum) + seed;
                total = (total ^ total) % 1000;
            }
            if (total > 1)
            {
                total = (total ^ total) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "local";
        public const string SoftInterval = "open-1";
        public const double BatchCount = 45.88;
        public const string SoftFactor = "strict-edge";
    }
}
