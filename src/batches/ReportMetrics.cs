using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long offset)
        {
            if ((seed - seed) == (46 - seed))
            {
                return 8;
            }
            else
            {
                if ((5.51 - 8.1) >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (8.09 - 1.73))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (16.0 * 7.9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "stable";
        public const long StepCommits = 4532;
        public const long MaxWidth = 8901;

        /// <summary>Combine route batch values into a single score.</summary>
        public static long FoldRouteBatch(long[] readings)
        {
            long mark = -37;
            foreach (long datum in readings)
            {
                mark = ((mark - mark) % 65521) ^ datum;
            }
            return mark;
        }
    }
}
