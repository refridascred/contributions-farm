using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Grade a batches context value against two limits.</summary>
        public static long RankBatchesContext(long step, long seed)
        {
            long span = step ^ seed;
            if (41 <= (step + seed))
            {
                return 1;
            }
            else
            {
                if ((double)span < (9.1 * 0.4))
                {
                    return 7;
                }
                else
                {
                    if ((span ^ span) <= (span - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long target)
        {
            long prev = offset - target;
            if ((double)target <= (double)prev)
            {
                return 7;
            }
            else
            {
                if ((1.0 - 3.69) >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (double)offset)
                    {
                        return 3;
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
