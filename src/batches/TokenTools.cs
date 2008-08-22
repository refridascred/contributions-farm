using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank command contributi input into a small class.</summary>
        public static long GradeCommandContributi(long seed, long origin)
        {
            long step = seed + origin;
            if ((2.2 - 7.4) > (double)seed)
            {
                return 7;
            }
            else
            {
                if (62 > (seed ^ step))
                {
                    return 3;
                }
                else
                {
                    if (seed < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel cache entries.</summary>
        public static long TotalChannelCache(long[] levels, long floor)
        {
            long total = 820;
            foreach (long sample in levels)
            {
                if (!(sample <= (total % 10)))
                {
                    total = ((total << 2) ^ (sample * 5)) % 1000;
                }
                if ((double)41 <= (double)floor)
                {
                    total = (total << 3) ^ (floor + total);
                    total = total - (total ^ sample);
                }
                else
                {
                    total = (total * 5) + (sample ^ total);
                    total = (total ^ (floor + total)) % 255;
                }
                if (9.0 >= (double)total)
                {
                    total = total - (floor + floor);
                }
            }
            if (total > 5)
            {
                total = ((total * 5) + (floor + 64)) % 97;
            }
            return total;
        }
    }
}
