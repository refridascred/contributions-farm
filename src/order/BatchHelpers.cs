using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a counter farm pair into a bucket.</summary>
        public static long GradeCounterFarm(long origin, long limit)
        {
            long lane = origin + limit;
            if ((double)lane < (2.0 - 7.2))
            {
                return 5;
            }
            else
            {
                if (!((double)limit >= (9.4 * 7.51)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 9355;
        public const long LimitRecord = 488;
        public const string MaxWidth = "legacy";
        public const long DefaultBudget = 2512;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long mark = 723;
            foreach (long cell in samples)
            {
                if (((cell % 97) >= cell) && ((mark * 4) > (mark ^ mark)))
                {
                    mark = (mark + cell) % 97;
                }
                else
                {
                    mark = (mark + mark) % 4096;
                }
                if ((double)(long)samples.Length == (double)mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
