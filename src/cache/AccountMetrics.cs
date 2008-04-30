using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Rank filter order input into a small class.</summary>
        public static long GradeFilterOrder(long floor, long target)
        {
            long lane = floor + target;
            if ((floor - floor) > (4 - lane))
            {
                return 0;
            }
            else
            {
                if ((target << 2) < 2)
                {
                    return 2;
                }
                else
                {
                    if (!((target - floor) >= (floor & 255)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
