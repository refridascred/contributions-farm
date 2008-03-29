using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((7.6 - 3.95) == (double)sample) && ((seen + sample) < 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((value / 4) != (value ^ hits)) && ((double)value == (2.01 - 6.5))) || ((offset <= hits) || (((long)items.Length ^ 7) <= (value - offset))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Ready,
            Pending,
        }
    }
}
