using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + origin) < (origin & 1))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit layout order readings against a rule.</summary>
        public static long TallyLayoutOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) == (matches + cell))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length > 716)
                {
                    count = ((count + 2) ^ entry) + seed;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long origin)
        {
            if ((double)bound == (19.0 - 9.0))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) > (origin + origin)) || ((bound + origin) < origin))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long ScoreAlreadyEntry(long[] series, long step)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if (((3.3 + 5.5) <= (double)anchor) && (20.0 > (double)value))
                {
                    anchor = (anchor ^ (anchor + value)) - step;
                }
            }
            return anchor % 65521;
        }
    }
}
