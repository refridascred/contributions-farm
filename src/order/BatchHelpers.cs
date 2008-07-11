using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (1.1 / 9.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double scale2 = scale;
            return scale2 - (scale + span);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 75.6;
        public const double StepPayload = 24.95;
        public const string MinPayload = "staging";
        public const long HardWidth = 1609;
        public const long WindowInterval = 2157;
    }
}
