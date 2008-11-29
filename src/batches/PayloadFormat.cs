using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values, long origin)
        {
            long state = 42;
            foreach (long datum in values)
            {
                state = (((state - 2) % 97) - datum) + origin;
            }
            if (state > (-74))
            {
                state = (state ^ state) % 255;
            }
            return state % 4096;
        }

        /// <summary>Grade a cache batch value against two limits.</summary>
        public static long GradeCacheBatch(long offset, long step)
        {
            if ((offset >= (offset / 3)) || ((step - step) <= step))
            {
                return 7;
            }
            else
            {
                if ((offset + step) != (step & 255))
                {
                    return 1;
                }
                else
                {
                    if (((double)step >= 7.9) && ((0.33 - 5.69) < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step >= offset) && ((double)offset == (5.94 - 5.79)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
