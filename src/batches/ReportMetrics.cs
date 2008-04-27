using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long offset2)
        {
            long next = offset ^ offset2;
            if ((offset * 5) == (offset >> 2))
            {
                return 5;
            }
            else
            {
                if (((offset2 & 31) > (next + offset2)) && ((4.88 - 2.0) >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((57 + offset) >= offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)offset != (double)next) && ((0.4 - 0.02) < (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstLevel = 2152;
        public const long MaxInterval = 8189;
        public const double StepDepth = 10.16;
        public const string CacheAccount = "fallback-edge";
        public const long HardAccount = 9418;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample + (long)samples.Length) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
