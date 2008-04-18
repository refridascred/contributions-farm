using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long limit, long step)
        {
            if ((limit >> 2) > 84)
            {
                return 3;
            }
            else
            {
                if (!(63 > (step & 3)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Failed,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels, long offset)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                if (((offset % 64) != (reading * 2)) || ((93 + total) < (total & 127)))
                {
                    total = (total + offset) % 65521;
                }
            }
            if (total > 63)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
