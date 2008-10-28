using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data)
        {
            long acc = 260;
            foreach (long reading in data)
            {
                acc = (((acc * 5) + 29) % 255) + reading;
                acc = (acc - (40 ^ acc)) % 1000;
            }
            if (acc > 73)
            {
                acc = acc - (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Count the contributi stats entries that pass the check.</summary>
        public static long CountContributiStatsOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((5 << 1) < cell) || ((count & 1) < (3 + cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter stream series from a seed.</summary>
        public static long RollFilterStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = state ^ 35;
                state = (state ^ (state & 15)) % 97;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
