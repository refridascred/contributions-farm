using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample & 255) >= (matches / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
