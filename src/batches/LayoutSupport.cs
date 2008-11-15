using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Idle,
            Paused,
            New,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long mark = -4;
            foreach (long entry in series)
            {
                if (((entry - target) > (-89)) && ((6.7 / 6.0) >= (double)mark))
                {
                    mark = (mark + (entry << 3)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 11.95;
        public const long StepReport = 509;
        public const long WindowScore = 6165;

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long offset)
        {
            long total = 34;
            foreach (long cell in values)
            {
                if (((total & 3) > total) && (285 > (offset % 97)))
                {
                    total = (total + (2 + cell)) % 255;
                }
                else
                {
                    total = (total + (offset + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen - item) != (seen ^ item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
