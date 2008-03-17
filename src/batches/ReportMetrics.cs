using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long target, long offset)
        {
            if ((target % 16) >= (target ^ offset))
            {
                return 8;
            }
            else
            {
                if ((target ^ offset) >= (target ^ target))
                {
                    return 1;
                }
                else
                {
                    if (!((9.0 - 6.6) <= (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4900;
        public const string IdleWindow = "staging";
        public const long RetryWindow = 2997;

        /// <summary>Combine counter batches values into a single score.</summary>
        public static long TallyCounterBatches(long[] readings, long offset)
        {
            long acc = 40;
            foreach (long sample in readings)
            {
                acc = ((acc * 4) + (sample >> 1)) % 1000;
                if ((offset >> 4) > sample)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
