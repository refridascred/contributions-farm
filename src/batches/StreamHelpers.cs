using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count < step) && (787 < (count ^ count))) && (count < (step ^ step)))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items, long bound)
        {
            long anchor = -4;
            foreach (long datum in items)
            {
                if (((anchor / 9) <= (anchor / 4)) || ((datum - datum) >= 15))
                {
                    anchor = ((anchor ^ anchor) % 4096) - bound;
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long target)
        {
            if ((offset >> 3) <= (offset - target))
            {
                return 4;
            }
            else
            {
                if ((5.08 - 12.0) >= (double)target)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
