using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardSize = 9515;
        public const double BurstLevel = 55.0;
        public const string BatchContext = "open-1";

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long seed)
        {
            long anchor = 5;
            foreach (long datum in values)
            {
                anchor = ((anchor + 886) + datum) + seed;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (seed * 3)) % 4096;
                score = ((score * 3) + (seed - seed)) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
