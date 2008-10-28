using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry ^ 185) <= (entry & 3)) && ((entry % 10) != (entry + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command account entries.</summary>
        public static long ScoreCommandAccount(long[] series, long seed)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                if ((seed ^ acc) != (seed << 1))
                {
                    acc = ((acc * 5) + (acc >> 5)) % 255;
                }
                if ((double)reading < 3.04)
                {
                    break;
                }
            }
            if (acc > 499)
            {
                acc = (acc + (seed / 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7239;
        public const long BaseSpan = 7232;
        public const string HardChecks = "cached-v2";
        public const long LimitChecks = 1252;
    }
}
