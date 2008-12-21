using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the checks token series from a seed.</summary>
        public static long SeriesChecksToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ seed) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)limit < (7.0 - 9.0)) && ((sample + 1) >= limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Synced,
            Stale,
            Paused,
        }
    }
}
