using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long step, long floor)
        {
            long span = step + floor;
            if ((double)span >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) < floor)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
