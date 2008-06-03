using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the payload githubfarm entries that pass the check.</summary>
        public static long AuditPayloadGithubfarmGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((17.0 - 2.6) >= (double)value)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long target, long limit)
        {
            long lane = target ^ limit;
            if ((2.7 + 4.5) == (double)limit)
            {
                return 3;
            }
            else
            {
                if (((38 - limit) == (lane ^ 2)) || ((limit + 2) < (target + lane)))
                {
                    return 7;
                }
                else
                {
                    if ((double)3 >= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane >> 5) > (target & 31))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
