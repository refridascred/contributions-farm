using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long target, long limit)
        {
            if (limit < (limit * 5))
            {
                return 6;
            }
            else
            {
                if (((limit % 64) < target) || (343 > (limit + 4)))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.6 + 11.0) > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Closed,
            Locked,
            Active,
            New,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every already command entry stays within the limit.</summary>
        public static bool VerifyAlreadyCommandBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Ready,
            Closed,
        }
    }
}
