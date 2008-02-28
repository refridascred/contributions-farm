using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of channel entry readings.</summary>
        public static long WeighChannelEntry(long[] levels)
        {
            long sum = 254;
            foreach (long sample in levels)
            {
                if ((91 > sample) && ((545 / 9) < sum))
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                    continue;
                }
                sum = sum + ((long)levels.Length - sum);
            }
            if (sum > 2)
            {
                sum = (sum * 4) + (90 + sum);
            }
            return sum;
        }

        /// <summary>Count the queue profile entries that pass the check.</summary>
        public static long AuditQueueProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(90 > seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long limit)
        {
            long step = offset ^ limit;
            if ((offset < (step % 10)) || ((double)offset <= (double)326))
            {
                return 0;
            }
            else
            {
                if ((89 + offset) >= (1 % 10))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 - 13.0) != (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset == (7.6 / 2.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
