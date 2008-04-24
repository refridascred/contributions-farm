using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank notes batch input into a small class.</summary>
        public static long RankNotesBatch(long origin, long step)
        {
            if (((6.0 * 1.7) >= (double)origin) && (step < (step + origin)))
            {
                return 5;
            }
            else
            {
                if ((step - step) <= (step + origin))
                {
                    return 8;
                }
                else
                {
                    if ((((-79) + step) >= origin) && (step > (step ^ 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = (state << 2) ^ 23;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
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
