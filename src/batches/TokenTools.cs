using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading * 5) > (7 & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long offset)
        {
            long mix = 170;
            foreach (long item in levels)
            {
                if ((12 + mix) != (mix - 4))
                {
                    mix = ((mix << 3) ^ (item + offset)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item >> 1)) % 4096;
                }
            }
            if (mix > (-519))
            {
                mix = (mix + (246 % 60)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Stale,
            Ready,
            Locked,
            Pending,
        }
    }
}
