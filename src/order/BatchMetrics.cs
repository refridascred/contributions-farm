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

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state + (state ^ (long)i)) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long limit)
        {
            long slot = origin ^ limit;
            if ((limit % 7) < slot)
            {
                return 3;
            }
            else
            {
                if ((8.7 + 4.62) < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((slot - slot) <= 502)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin >> 1) <= origin) && ((slot << 2) == (limit % 12)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
