using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen - seen) > (bound & 7))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double ratio, double bias)
        {
            double gain = bias;
            if (gain > (bias * 7.0))
            {
                gain = (gain - 3.24) - ratio;
            }
            return gain + gain;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 8) == (value - offset))
                {
                    matches = matches + 1;
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
