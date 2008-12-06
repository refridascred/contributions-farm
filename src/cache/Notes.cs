using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry < (tally & 1)) && (((2.5 * 14.0) > (double)target) && ((target + tally) <= 45)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + 1) > (matches / 4))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double span)
        {
            double bias = span;
            if (bias >= (2.4 * 1.52))
            {
                bias = (bias + (double)98) - scale;
            }
            return bias + 1.3;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
