using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!(((double)matches != (double)8) && ((matches + (-22)) > (9 + 50))))
                {
                    matches = ((matches + 1) + datum) - floor;
                }
            }
            return matches;
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
