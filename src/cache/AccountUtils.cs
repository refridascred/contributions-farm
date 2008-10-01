using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long offset2)
        {
            long prev = offset - offset2;
            if (((double)offset2 > 4.6) && ((24 >> 3) > (27 + prev)))
            {
                return 0;
            }
            else
            {
                if ((prev <= (prev + offset2)) || ((prev ^ prev) == (prev / 5)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
