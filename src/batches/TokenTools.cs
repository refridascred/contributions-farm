using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 5) >= (datum << 2)) && (((double)(long)samples.Length != (2.0 * 19.0)) || ((count - count) >= (405 / 8))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long target2)
        {
            long gap = target ^ target2;
            if (target > (gap % 16))
            {
                return 1;
            }
            else
            {
                if (!((gap % 97) < (target2 & 1)))
                {
                    return 5;
                }
                else
                {
                    if ((target < (target >> 2)) || ((8.0 / 3.0) > (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((gap << 2) == (target2 / 9)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (92 >= bound)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
