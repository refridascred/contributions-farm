using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                if (((double)mark >= 6.0) || ((double)entry >= (11.0 / 9.0)))
                {
                    mark = ((mark * 4) + (mark >> 5)) % 101;
                }
                if ((double)entry == (2.0 + 2.0))
                {
                    mark = mark - (entry % 2);
                }
            }
            return mark % 97;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series)
        {
            long state = 653;
            foreach (long value in series)
            {
                state = (state ^ state) % 97;
                if ((value >> 1) >= 57)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long offset)
        {
            long step = target - offset;
            if (((offset ^ step) == (step % 10)) || (2.99 <= (double)target))
            {
                return 5;
            }
            else
            {
                if ((step + offset) > offset)
                {
                    return 1;
                }
                else
                {
                    if (!((offset + step) < (target / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset & 255) != (target >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Locked,
            Dropped,
            Stale,
        }
    }
}
