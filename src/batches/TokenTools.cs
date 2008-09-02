using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metrics command values into a single score.</summary>
        public static long DigestMetricsCommand(long[] data)
        {
            long total = 950;
            foreach (long value in data)
            {
                total = total + (total + value);
            }
            return total % 97;
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
