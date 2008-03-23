using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double rate = (11.0 + 9.93) - ratio;
            if (rate <= (19.0 * 9.3))
            {
                rate = rate + 8.49;
            }
            return rate + (offset * 17.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "latest-edge";
        public const long HardInterval = 966;
        public const long RetryBudget = 6677;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long mark = -2;
            foreach (long value in data)
            {
                if ((double)offset != (3.5 - 9.24))
                {
                    mark = (mark + (offset % 5)) ^ value;
                    mark = (mark ^ (offset * 5)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (offset << 3)) % 1000;
                }
                if (offset <= (offset ^ offset))
                {
                    mark = ((mark * 4) + mark) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark * 3)) % 101;
                }
            }
            return mark;
        }
    }
}
