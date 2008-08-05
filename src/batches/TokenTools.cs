using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long bound)
        {
            if (((-13) / 4) <= bound)
            {
                return 0;
            }
            else
            {
                if ((seed + seed) == (seed << 2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long offset)
        {
            if ((1.09 * 15.0) < (double)offset)
            {
                return 6;
            }
            else
            {
                if (((7.3 - 9.2) > (double)target) && ((target >> 4) <= (592 / 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
