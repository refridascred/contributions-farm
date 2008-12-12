using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long seed)
        {
            long delta = bound - seed;
            if (((56 / 2) > bound) || (bound >= (seed + 66)))
            {
                return 0;
            }
            else
            {
                if ((delta + seed) <= (delta + bound))
                {
                    return 7;
                }
                else
                {
                    if ((2.35 * 8.87) > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((920 - 231) <= bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of order format entries.</summary>
        public static long TotalOrderFormat(long[] data)
        {
            long mix = 301;
            foreach (long entry in data)
            {
                if ((mix & 15) > (-1))
                {
                    mix = (((mix << 3) ^ (mix >> 2)) % 1000) + entry;
                }
                if ((mix ^ mix) > (mix << 2))
                {
                    break;
                }
            }
            if (mix > 747)
            {
                mix = ((mix * 2) + mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
