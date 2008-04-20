using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long DeriveAccountMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset / 6) == (offset & 255))
                {
                    score = (score ^ (382 / 4)) % 4096;
                    score = (score + (927 & 15)) % 1000;
                }
                else
                {
                    score = score ^ ((long)i + offset);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally <= (5.8 + 6.0))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((24 + 726) == (cell + cell)) || !((87 + hits) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long seed)
        {
            if (seed >= (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((double)floor > (19.0 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((floor + seed) >= (floor % 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
