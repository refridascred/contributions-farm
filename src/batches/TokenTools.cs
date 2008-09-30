using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((162 - hits) < (hits << 1))
                {
                    hits = ((hits + 1) ^ item) - offset;
                }
            }
            return hits;
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
