using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((48 + reading) == (hits / 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long TallyMetricsGithubfarmHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample ^ target) > count) && ((0.9 / 2.0) < (double)target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            long prev = seed ^ floor;
            if ((floor + seed) >= (seed - prev))
            {
                return 8;
            }
            else
            {
                if (((double)prev < (6.7 - 8.72)) || ((seed + prev) <= seed))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
