using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count order cache pairs that satisfy a relation.</summary>
        public static long MatchOrderCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values)
        {
            long total = 29;
            foreach (long sample in values)
            {
                if ((sample * 3) != (total + total))
                {
                    total = ((total * 2) + (total >> 2)) % 97;
                }
            }
            if (total < 1)
            {
                total = (total + 4) % 1000;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches >= (long)samples.Length)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long step)
        {
            long state = 96;
            foreach (long sample in readings)
            {
                state = ((((state * 5) + (57 % 60)) % 255) - sample) - step;
            }
            return state % 97;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long target2)
        {
            long prev = target + target2;
            if ((1 * 4) > (target - prev))
            {
                return 6;
            }
            else
            {
                if (!((prev << 2) >= (43 / 7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target2 <= (0.34 + 9.33))
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

        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long MeasureClusterAccountOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)count > (double)offset))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
