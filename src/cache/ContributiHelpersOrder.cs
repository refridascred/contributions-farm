using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((475 & 7) == (origin2 + origin2))
            {
                return 1;
            }
            else
            {
                if (((-8) - cur) > (cur - cur))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (double)31)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long target)
        {
            if (((-4) - limit) > (limit * 5))
            {
                return 2;
            }
            else
            {
                if ((target >> 1) == (target << 1))
                {
                    return 0;
                }
                else
                {
                    if (((double)target != (double)330) || ((double)target != (5.75 / 8.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
