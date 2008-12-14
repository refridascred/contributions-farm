using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics contributi figure with a bias.</summary>
        public static double AdjustMetricsContributi(double gain, double span)
        {
            double scale = span;
            if (scale <= (scale / 8.0))
            {
                scale = (scale + (4.54 - scale)) + gain;
            }
            return scale - scale;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] values, long floor)
        {
            long score = 6;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (score % 24)) - reading;
            }
            if (score > 435)
            {
                score = (score + (floor + floor)) % 4096;
            }
            return score;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((target + 9) >= (target & 255))
                {
                    matches = (matches + 2) - entry;
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
