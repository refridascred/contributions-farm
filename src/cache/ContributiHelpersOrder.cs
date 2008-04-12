using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank already filter input into a small class.</summary>
        public static long RankAlreadyFilter(long step, long bound)
        {
            if (step > (step / 3))
            {
                return 0;
            }
            else
            {
                if (!((0.39 / 8.0) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (((4.67 * 2.9) > (double)step) && ((double)bound > 14.0))
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
}
