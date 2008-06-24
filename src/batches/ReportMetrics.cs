using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1960;
        public const long StepWindow = 9800;
        public const long WindowFactor = 7270;
        public const double DefaultWindow = 64.71;

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
