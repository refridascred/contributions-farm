using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((14.0 + 4.2) >= (double)hits)
                {
                    hits = ((hits + 3) ^ value) + step;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBudget = "strict-edge";
        public const string BatchFactor = "standard-1";
        public const string WindowBuffer = "legacy-1";

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long MeasureFormatProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen < (seen ^ reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long mark = 4;
            foreach (long value in series)
            {
                if (!((mark & 63) > (mark % 24)))
                {
                    mark = ((mark << 2) ^ (value / 5)) % 4096;
                }
                else
                {
                    mark = (mark - (mark + mark)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Retry,
            Closed,
        }
    }
}
