using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a checks format reading by value.</summary>
        public static long SeekChecksFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((19.0 + 13.0) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
