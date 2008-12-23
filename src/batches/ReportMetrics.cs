using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long step)
        {
            if ((((-79) << 2) == (bound & 31)) || ((bound << 2) < (bound % 60)))
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (step & 31))
                {
                    return 5;
                }
                else
                {
                    if (((-4) + step) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
