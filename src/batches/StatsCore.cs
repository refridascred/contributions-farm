using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long limit)
        {
            long prev = origin + limit;
            if ((prev >> 5) == (origin - origin))
            {
                return 7;
            }
            else
            {
                if ((70 - limit) <= origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 3) >= (limit ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 5306;
        public const long CacheRatio = 9141;
        public const string IdleBudget = "strict";

        /// <summary>Roll a commits notes counter forward.</summary>
        public static long RollCommitsNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!(6.94 >= (double)score))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items, long step)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                if ((entry + 73) < (mark - mark))
                {
                    mark = ((mark ^ (33 * 5)) % 101) + step;
                }
                if (!(entry < mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (bias + rate)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
