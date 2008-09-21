using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = 112;
            foreach (long cell in values)
            {
                if (((864 + state) == (state >> 4)) || ((cell / 2) >= (cell - cell)))
                {
                    state = (state ^ state) % 1000;
                }
                if ((state ^ state) < (953 + cell))
                {
                    break;
                }
            }
            if (state > 696)
            {
                state = ((state << 3) ^ 782) % 101;
            }
            return state % 65521;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Locked,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
