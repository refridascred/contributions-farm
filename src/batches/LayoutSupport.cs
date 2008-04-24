using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long step)
        {
            long cur = target ^ step;
            if (cur >= target)
            {
                return 0;
            }
            else
            {
                if (((double)cur >= 14.0) && ((step & 7) >= (1 + 7)))
                {
                    return 5;
                }
                else
                {
                    if (target > (step + 94))
                    {
                        return 1;
                    }
                    else
                    {
                        if (81 <= (target - cur))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats cache readings against a rule.</summary>
        public static long CountStatsCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((-9) >= (tally + tally))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Draft,
            Active,
            New,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ ((long)i & 127);
                if (((anchor + (long)i) >= anchor) || ((4.4 * 10.0) > (double)(long)i))
                {
                    anchor = (anchor - (long)i) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
