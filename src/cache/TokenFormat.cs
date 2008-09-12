using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] data, long floor)
        {
            long score = -6;
            foreach (long cell in data)
            {
                score = ((score + (floor % 8)) % 97) ^ cell;
            }
            if (score > 63)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Validate schema metrics readings against a bound.</summary>
        public static bool CheckSchemaMetricsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a commits entry pair into a bucket.</summary>
        public static long BucketCommitsEntry(long limit, long offset)
        {
            if ((limit + limit) < (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= (15.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
