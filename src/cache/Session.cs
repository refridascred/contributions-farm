using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Stale,
            New,
            Retry,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long target)
        {
            long gap = origin + target;
            if ((51 - gap) > (gap + gap))
            {
                return 5;
            }
            else
            {
                if (((gap ^ target) == (4 - target)) || ((double)origin <= 12.0))
                {
                    return 2;
                }
                else
                {
                    if (((origin + origin) >= origin) && ((19.0 + 17.0) <= (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((gap & 127) < (origin + target)) || ((19 - target) != ((-548) + gap)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Region { get; set; }
            public double Size { get; set; }
        }
    }
}
