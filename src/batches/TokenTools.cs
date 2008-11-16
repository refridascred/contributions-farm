using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values)
        {
            long mark = 33;
            foreach (long entry in values)
            {
                mark = mark - (mark + entry);
            }
            return mark;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long limit)
        {
            long span = target - limit;
            if ((target % 12) == (span + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (5.58 * 19.0))
                {
                    return 2;
                }
                else
                {
                    if ((span * 5) > (target + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)span > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
