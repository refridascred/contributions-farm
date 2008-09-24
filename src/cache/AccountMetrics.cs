using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - datum) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor account value against two limits.</summary>
        public static long ClassifyEditorAccount(long floor, long bound)
        {
            long next = floor - bound;
            if ((next % 64) < (bound + bound))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= (668 >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor == (double)bound) && ((9.18 * 9.12) == (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long seed)
        {
            if ((bound - seed) >= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((bound & 7) <= (bound / 3))
                {
                    return 2;
                }
                else
                {
                    if (seed > (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)36 >= (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits + hits) > (7 / 5)) && (hits < (hits * 3)))
                {
                    hits = ((hits + 1) + sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window stats readings.</summary>
        public static long DigestWindowStats(long[] series, long floor)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = ((acc ^ (value - acc)) % 65521) - floor;
                acc = ((acc << 3) ^ value) % 1000;
            }
            return acc;
        }
    }
}
