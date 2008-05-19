using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entry entries that pass the check.</summary>
        public static long TallyStatsEntryOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(cell <= (step % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
