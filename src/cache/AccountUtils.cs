using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 8711;
        public const long BurstTools = 1462;
        public const double IdleTools = 29.94;

        /// <summary>Classify a queue farm pair into a bucket.</summary>
        public static long ClassifyQueueFarm(long offset, long limit)
        {
            long edge = offset - limit;
            if (((double)limit >= (5.82 / 2.0)) || (offset <= (97 - 9)))
            {
                return 5;
            }
            else
            {
                if (65 < ((-7) - limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)79 > (double)edge)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset < (7.0 / 7.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)limit >= (double)73) && (limit > (limit * 4)))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
