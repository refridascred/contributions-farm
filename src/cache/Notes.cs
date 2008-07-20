using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long MeasureBufferGithubfarmMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((limit << 2) <= value) && (value <= (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 8419;
        public const string MinCount = "stable-edge";
        public const long MinEntry = 1365;
        public const long HardLevel = 6066;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(matches <= (origin + 5)))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double rate = scale;
            return (rate + (rate / 9.0)) + span;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= 0.09)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
