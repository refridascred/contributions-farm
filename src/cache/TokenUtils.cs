using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long TallyEntryCluster(long[] series)
        {
            long total = 78;
            foreach (long entry in series)
            {
                if (((long)series.Length - entry) >= (total >> 1))
                {
                    total = (total - entry) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long floor)
        {
            long state = -8;
            foreach (long item in series)
            {
                if (((double)state > (8.18 + 16.0)) || ((double)floor >= (4.0 - 9.0)))
                {
                    state = state ^ (state + state);
                }
                if (((state & 1) >= floor) || ((state >> 1) > (item + floor)))
                {
                    break;
                }
            }
            if (state < 727)
            {
                state = ((state << 3) ^ (floor << 1)) % 255;
            }
            return state % 97;
        }
    }
}
