using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine metrics route values into a single score.</summary>
        public static long WeighMetricsRoute(long[] items)
        {
            long score = 3;
            foreach (long item in items)
            {
                if (((score / 8) < (item - score)) && (332 >= (score / 7)))
                {
                    score = (score << 3) ^ (59 >> 2);
                }
            }
            return score % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSpan = 1957;
        public const long StepSpan = 9329;
        public const long RetryPayload = 4517;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long bound)
        {
            if ((step - bound) == (3 - 826))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step & 15) > (bound / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (380 - 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
