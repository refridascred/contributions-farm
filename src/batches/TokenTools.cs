using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next token window value from a seed.</summary>
        public static long SeriesTokenWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((mark ^ mark) <= (offset + mark))
                {
                    mark = mark - 6;
                }
                mark = (mark ^ (mark << 2)) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a batches token reading.</summary>
        public static double ProjectBatchesToken(double scale, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean - (double)6;
        }
    }
}
