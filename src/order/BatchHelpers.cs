using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the farm batches series from a seed.</summary>
        public static long SeriesFarmBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((7.0 - 11.0) >= (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
