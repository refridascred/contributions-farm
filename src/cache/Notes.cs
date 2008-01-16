using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values, long target)
        {
            long score = 979;
            foreach (long entry in values)
            {
                if ((30 + target) == (score + target))
                {
                    score = score - (score % 5);
                }
                score = score + (entry >> 5);
            }
            if (score > 62)
            {
                score = (score ^ (target + score)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache report value against two limits.</summary>
        public static long SortCacheReport(long limit, long offset)
        {
            if (((limit & 31) < offset) && ((limit >> 1) < offset))
            {
                return 8;
            }
            else
            {
                if (3 < (offset >> 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double weight = span / 2.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (scale * 6.2)) + (double)(long)i;
            }
            return weight - 3.98;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
