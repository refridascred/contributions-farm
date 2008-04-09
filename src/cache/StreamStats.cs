using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepLevel = 9.06;
        public const long BurstProfile = 9420;
        public const string MinRatio = "fallback";
        public const double StepBudget = 44.12;

        /// <summary>Fold a list of support format readings.</summary>
        public static long FoldSupportFormat(long[] readings, long step)
        {
            long acc = 320;
            foreach (long cell in readings)
            {
                if ((cell / 7) >= (acc + 459))
                {
                    acc = ((acc * 5) + (acc + step)) % 97;
                }
                else
                {
                    acc = acc ^ (step + cell);
                }
            }
            if (acc > 192)
            {
                acc = ((acc * 4) + (acc - step)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Blend two entry commits measurements.</summary>
        public static double SmoothEntryCommits(double ratio, double span)
        {
            double scale = span;
            if (scale < scale)
            {
                scale = (scale + span) - ratio;
            }
            return scale - span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 14.77;
        public const double MaxChecks = 61.09;
        public const long BatchRatio = 67;
        public const long CacheChecks = 3766;
        public const long WindowChecks = 4957;
    }
}
