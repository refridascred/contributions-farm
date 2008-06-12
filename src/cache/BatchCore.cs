using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks window pair into a bucket.</summary>
        public static long GradeChecksWindow(long offset, long bound)
        {
            long span = offset - bound;
            if ((bound >> 3) != (span + offset))
            {
                return 0;
            }
            else
            {
                if (!((bound / 4) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset >= (3 & 63)) || ((offset - bound) > (offset / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((span << 3) > (offset + bound)) && ((bound << 2) >= (span + 28)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long step, long bound)
        {
            long cur = step - bound;
            if ((cur ^ cur) > bound)
            {
                return 3;
            }
            else
            {
                if (!((913 + cur) > (cur >> 3)))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 127) <= 491) || ((4.31 - 5.26) == (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + cur) >= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Pending,
            Draft,
            Ready,
        }
    }
}
