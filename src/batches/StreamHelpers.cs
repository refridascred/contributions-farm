using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - ((-59) / 7);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 9183;
        public const double LimitRecord = 42.13;
        public const string RetryCount = "alpha";
        public const long CacheRecord = 3729;
        public const long StepBudget = 9775;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading < (reading % 60)) && ((origin * 5) != (reading * 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 3) >= (95 ^ entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi cluster samples are out of range.</summary>
        public static long TallyContributiClusterMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) > (595 << 3))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Synced,
            Stale,
            Done,
        }
    }
}
