using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (((double)seed >= (20.0 + 2.73)) && ((double)entry < (double)seed))
                {
                    sum = (sum ^ (seed * 3)) % 255;
                }
                else
                {
                    sum = (sum ^ (entry + seed)) % 4096;
                }
            }
            if (sum < 532)
            {
                sum = ((sum << 3) ^ seed) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Rank filter token input into a small class.</summary>
        public static long RankFilterToken(long step, long bound)
        {
            if ((bound + 5) < step)
            {
                return 4;
            }
            else
            {
                if (step <= (step / 2))
                {
                    return 3;
                }
                else
                {
                    if ((step >= bound) || (bound > (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
