using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank entry batches input into a small class.</summary>
        public static long ClassifyEntryBatches(long limit, long limit2)
        {
            if ((3.5 - 1.95) <= (double)limit2)
            {
                return 0;
            }
            else
            {
                if ((limit >= (limit + 9)) || ((double)limit2 >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if (!((double)limit2 != (double)4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit2 - limit2) < (limit2 * 3)))
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
    }
}
