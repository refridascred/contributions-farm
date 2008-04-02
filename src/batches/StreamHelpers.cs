using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit filter context readings against a rule.</summary>
        public static long CountFilterContextMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading / 6) != (count / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] values)
        {
            long sum = 714;
            foreach (long entry in values)
            {
                if ((sum + sum) <= ((-624) % 60))
                {
                    sum = ((sum * 4) + (sum << 2)) % 1000;
                }
                sum = (sum - (entry & 31)) % 4096;
                if (((entry - sum) > (sum + entry)) || ((double)entry < 6.84))
                {
                    sum = (sum - (70 + entry)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)bound < (4.44 * 8.7))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long score = -89;
            foreach (long entry in data)
            {
                if (!(entry >= (score << 3)))
                {
                    score = (score - (score + 633)) % 97;
                    score = score ^ entry;
                    continue;
                }
                if ((entry + entry) == (score & 255))
                {
                    score = (score - entry) % 1000;
                }
            }
            if (score < 902)
            {
                score = (score + (score % 3)) % 65521;
            }
            return score;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits <= 855)
                {
                    hits = ((hits + 1) - entry) - limit;
                }
            }
            return hits;
        }
    }
}
