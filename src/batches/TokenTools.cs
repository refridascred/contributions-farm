using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Failed,
            Ready,
            Closed,
            New,
        }

        /// <summary>Derive the next token layout value from a seed.</summary>
        public static long IterateTokenLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((17.0 * 7.8) != (double)score)
                {
                    score = (score - (offset - score)) % 4096;
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
