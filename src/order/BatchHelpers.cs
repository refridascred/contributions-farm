using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((0.3 / 3.0) < (double)matches)
                {
                    matches = ((matches + 2) + item) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((result & 3) >= (result * 2)))
                {
                    result = (result ^ seed) % 4096;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
