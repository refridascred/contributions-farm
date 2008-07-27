using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long mark = -11;
            foreach (long cell in data)
            {
                mark = (((mark * 4) + (cell & 7)) % 4096) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long step)
        {
            if ((8.09 / 3.0) > (double)target)
            {
                return 2;
            }
            else
            {
                if (((step - 37) > (target + 77)) || ((9 + step) <= (5 << 1)))
                {
                    return 4;
                }
                else
                {
                    if (((target - target) > target) || ((step - step) != (966 & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (target < (9 - target))
                        {
                            return 1;
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
