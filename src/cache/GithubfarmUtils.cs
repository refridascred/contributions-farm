using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count <= 6.79)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long MeasureRouteCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 12) <= (cell + 235))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long TallyAlreadyBatch(long[] data, long target)
        {
            long mix = 151;
            foreach (long item in data)
            {
                if ((target << 3) >= 94)
                {
                    mix = (mix - (item & 15)) % 4096;
                }
            }
            if (mix > 5)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)3 < (double)seen)
                {
                    seen = (seen + 1) ^ reading;
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
