using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step / 6) <= (step - (-898)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9395;
        public const long CacheFarm = 4770;
        public const long StepFarm = 8956;
        public const double BaseFarm = 14.2;
        public const long StepRatio = 4349;

        /// <summary>Rank tools command input into a small class.</summary>
        public static long BucketToolsCommand(long offset, long limit)
        {
            if ((double)limit >= (9.3 - 6.0))
            {
                return 6;
            }
            else
            {
                if ((96 + limit) == (offset + limit))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 4) <= (offset - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset == (1.4 * 8.76))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
