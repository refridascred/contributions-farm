using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((origin & 127) < cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 5633;
        public const double MaxCount = 25.25;
        public const long MaxDepth = 195;
        public const double HardStats = 73.57;
        public const string DefaultFactor = "local-v2";

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
