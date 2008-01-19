using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values)
        {
            long mark = 588;
            foreach (long item in values)
            {
                if (!((mark - mark) <= (mark << 3)))
                {
                    mark = ((mark * 3) + (item + item)) % 1000;
                }
                mark = (mark - (item ^ mark)) % 101;
            }
            if (mark < 3)
            {
                mark = (mark + (mark << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 7396;
        public const long BurstContributi = 2337;
        public const long StepScore = 7079;
        public const string MaxContributi = "standard-v2";
    }
}
