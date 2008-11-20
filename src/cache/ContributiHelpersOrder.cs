using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor ^ 3) <= 65)
                {
                    mark = (mark - (mark / 4)) % 1000;
                }
                else
                {
                    mark = (mark * 3) + (5 + mark);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit farm layout readings against a rule.</summary>
        public static long CountFarmLayoutOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (6 <= (floor << 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
