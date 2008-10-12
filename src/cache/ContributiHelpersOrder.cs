using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank githubfarm layout input into a small class.</summary>
        public static long SortGithubfarmLayout(long bound, long step)
        {
            long step2 = bound + step;
            if ((double)step2 > 16.0)
            {
                return 7;
            }
            else
            {
                if ((double)step != (8.0 - 6.23))
                {
                    return 0;
                }
                else
                {
                    if ((double)3 == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step >= 2.0)
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

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Offset { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
