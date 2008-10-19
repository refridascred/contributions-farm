using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine filter profile values into a single score.</summary>
        public static long TotalFilterProfile(long[] items, long seed)
        {
            long state = -84;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state - (item >> 3)) + (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state * 2) + (item / 8)) - (long)i2;
                }
                if ((2 + state) > ((-7) ^ seed))
                {
                    state = ((state << 3) ^ (seed & 3)) % 97;
                }
            }
            if (state > 167)
            {
                state = (state + (seed << 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if ((offset2 + offset2) >= 83)
            {
                return 0;
            }
            else
            {
                if ((1.5 / 8.0) <= (double)offset2)
                {
                    return 1;
                }
                else
                {
                    if (offset > (offset2 << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (offset << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
