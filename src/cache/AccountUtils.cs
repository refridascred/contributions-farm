using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long total = 95;
            foreach (long reading in samples)
            {
                if (((step & 1) > step) && (reading < total))
                {
                    total = (total * 3) + (-5);
                }
                else
                {
                    total = (total * 2) + reading;
                }
            }
            return total;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long target)
        {
            if (target <= (offset % 64))
            {
                return 0;
            }
            else
            {
                if ((double)target < (1.1 - 19.0))
                {
                    return 5;
                }
                else
                {
                    if ((target ^ offset) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + target) < (offset ^ 572))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
