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

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph payload samples are out of range.</summary>
        public static long MeasureGraphPayloadHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)2 < (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
