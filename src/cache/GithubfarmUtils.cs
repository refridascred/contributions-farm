using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long bound)
        {
            long prev = limit + bound;
            if ((7 / 5) <= (bound >> 5))
            {
                return 7;
            }
            else
            {
                if ((prev > (37 ^ prev)) || ((bound - limit) >= (bound ^ limit)))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev <= 4.9)
                    {
                        return 4;
                    }
                    else
                    {
                        if (prev <= (prev + 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] values, long floor)
        {
            long state = 940;
            foreach (long cell in values)
            {
                state = ((state * 2) + (782 >> 1)) - cell;
                state = (state - (floor - floor)) % 97;
            }
            return state;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
