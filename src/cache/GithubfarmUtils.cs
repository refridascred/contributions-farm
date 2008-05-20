using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) < (step ^ entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits > 1) || ((double)sample > (1.5 / 6.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((gap * 2) >= (469 + origin))
            {
                return 1;
            }
            else
            {
                if (gap >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 1) != (origin2 + origin2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)gap < (3.0 / 3.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
