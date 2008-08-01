using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                long step2 = step;
                if ((step ^ step2) != (step2 - step))
                {
                    mark = ((mark * 2) + (mark ^ step)) % 1000;
                }
                step2 = step2 ^ (step2 - step2);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 7755;
        public const long HardToken = 8175;
        public const string DefaultWidth = "fallback-1";

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
