using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i < (20 + origin)) && (origin <= 93))
                {
                    mix = ((mix << 3) ^ (origin + mix)) % 4096;
                }
                mix = (mix * 2) + ((long)i * 4);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
