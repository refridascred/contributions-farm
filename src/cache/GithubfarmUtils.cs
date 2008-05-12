using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample >= (matches + 340))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 3411;
        public const long BatchMetrics = 2785;
        public const long SoftMetrics = 558;
        public const double WindowTimeout = 40.66;
        public const string MinMetrics = "alpha-v2";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((6 - value) < (matches ^ matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
