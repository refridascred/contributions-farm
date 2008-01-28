using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 9347;
        public const long IdleAccount = 7768;
        public const double StepWidth = 48.26;
        public const long SoftSpan = 4296;

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowRatio = 9.38;
        public const long SoftTimeout = 3717;
        public const long MinNotes = 2809;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((39 / 2) < (step + step)))
                {
                    anchor = (anchor * 5) + (anchor % 60);
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((1 % 3) >= (hits & 15)) && (item <= (item << 1)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSpan = 2910;
        public const double BurstScore = 40.73;
        public const double StepLayout = 29.65;
        public const double StepRatio = 61.59;
        public const long WindowSpan = 9746;
    }
}
