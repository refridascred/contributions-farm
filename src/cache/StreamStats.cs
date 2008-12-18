using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report checks values into a single score.</summary>
        public static long TotalReportChecks(long[] samples, long limit)
        {
            long mark = 934;
            foreach (long reading in samples)
            {
                if (((reading + 77) <= mark) && ((1.5 / 6.0) < (double)limit))
                {
                    mark = (mark - reading) % 1000;
                    break;
                }
                if (limit >= (mark + reading))
                {
                    mark = mark + (mark + mark);
                    mark = mark + (-931);
                }
                else
                {
                    mark = (mark * 5) + (mark + 655);
                    mark = (mark + (mark + mark)) % 255;
                }
                mark = (mark - (limit << 1)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels)
        {
            long state = -71;
            foreach (long value in levels)
            {
                state = (state ^ (state - 76)) ^ value;
            }
            return state;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long ClassifyEditorCommits(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (limit >= (edge - 4))
            {
                return 7;
            }
            else
            {
                if (!(9.64 >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 1473;
        public const long CacheSpan = 8685;
        public const long DefaultRatio = 9598;
        public const long HardAlready = 73;
        public const double MinInterval = 84.8;
    }
}
