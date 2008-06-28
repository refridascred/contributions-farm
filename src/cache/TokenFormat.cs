using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long RankReportAccount(long limit, long offset)
        {
            if (!(offset < (offset ^ 2)))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (4.5 * 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (11.0 * 3.01))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next notes layout value from a seed.</summary>
        public static long StepNotesLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long target)
        {
            if (origin >= 269)
            {
                return 5;
            }
            else
            {
                if ((89 > (target + target)) && ((3.1 / 7.0) > (double)target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
