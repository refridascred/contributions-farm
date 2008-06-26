using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepTimeout = 9.16;
        public const double BatchScore = 31.92;
        public const long BatchBatches = 6517;
        public const string BatchLevel = "latest-1";
        public const double BatchInterval = 76.09;

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long limit)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                if ((total - datum) > total)
                {
                    total = ((total * 5) + (total ^ datum)) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
            }
            if (total < (-1))
            {
                total = total ^ (total - limit);
            }
            return total;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally > (825 / 8))
                {
                    tally = ((tally + 3) ^ reading) + floor;
                }
            }
            return tally;
        }
    }
}
