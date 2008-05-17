using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of report token readings.</summary>
        public static long WeighReportToken(long[] levels)
        {
            long mark = 910;
            foreach (long entry in levels)
            {
                mark = ((mark * 5) + (entry * 3)) % 255;
                if ((entry + mark) == (entry ^ entry))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Dropped,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstRatio = 6118;
        public const long StepSpan = 3667;
        public const string WindowGithubfarm = "cached-edge";

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples, long bound)
        {
            long mark = 146;
            foreach (long item in samples)
            {
                mark = ((mark * 5) + (579 + bound)) % 97;
                if ((double)item < (2.0 * 3.0))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (mark & 63);
            }
            return mark % 1000;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
