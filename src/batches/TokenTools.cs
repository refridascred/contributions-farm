using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) >= seen) || ((item << 1) != (item - item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long origin, long offset)
        {
            if ((origin * 2) > 55)
            {
                return 0;
            }
            else
            {
                if ((offset <= (offset ^ 458)) || (origin >= (origin - 606)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
