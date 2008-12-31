using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items)
        {
            long score = 301;
            foreach (long value in items)
            {
                score = (score - (value ^ score)) % 1000;
                score = ((score * 4) + 7) % 65521;
                if (993 <= score)
                {
                    score = ((score * 4) + value) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
