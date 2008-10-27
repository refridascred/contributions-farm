using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((limit > 556) && (5 < (limit >> 3)))
            {
                return 0;
            }
            else
            {
                if (((8 ^ offset) > (span % 100)) && ((double)limit >= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (!(offset <= (offset / 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a window notes reading.</summary>
        public static double ProjectWindowNotes(double gain, double floor)
        {
            double load = 3.58;
            return ((load - load) + gain) + floor;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples)
        {
            long state = 7;
            foreach (long cell in samples)
            {
                if ((state >> 5) != (cell / 6))
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] items, long step)
        {
            long score = 620;
            foreach (long cell in items)
            {
                if ((step / 8) > (step << 2))
                {
                    score = (score << 2) ^ (score + cell);
                }
            }
            return score;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
