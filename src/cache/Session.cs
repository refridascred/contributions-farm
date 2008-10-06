using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long score = 933;
            foreach (long entry in values)
            {
                if ((((long)values.Length * 3) == (63 ^ entry)) && ((score % 60) != ((-5) % 12)))
                {
                    continue;
                }
                score = (score ^ (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long origin)
        {
            if ((2 / 2) != (313 ^ bound))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (3.3 * 1.6))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i * 3) <= 6)
                {
                    total = (total ^ (451 % 3)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
