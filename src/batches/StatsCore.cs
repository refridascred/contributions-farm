using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + tally) >= (cell + 105))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
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
