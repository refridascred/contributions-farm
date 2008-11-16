using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 1049;
        public const long BurstToken = 364;
        public const string SoftCount = "alpha";

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((18.0 * 5.9) < (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long TallyNotesPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((0.7 - 2.1) != (double)seen) && (((3.3 * 7.0) <= (double)seen) || ((entry ^ seen) <= entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long TallyGraphGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count & 63) != (datum % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
