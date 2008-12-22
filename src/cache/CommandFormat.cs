using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series)
        {
            long anchor = 226;
            foreach (long entry in series)
            {
                if ((3.5 * 8.8) == (double)anchor)
                {
                    anchor = ((anchor + 35) % 4096) - entry;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((double)hits <= 1.8) && !((136 >> 4) <= (cell * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long CountMetricGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= 5.36)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardWidth = "staging-v2";
        public const string SoftReport = "stable-edge";
        public const double MinReport = 53.44;
        public const long SoftSpan = 9811;
    }
}
