using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the route account entries that pass the check.</summary>
        public static long MeasureRouteAccountHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell - seen) != (seed << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
