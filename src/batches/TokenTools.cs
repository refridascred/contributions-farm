using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long MeasureBatchAccountGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((seed <= entry) || ((seed << 1) == (6 >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
