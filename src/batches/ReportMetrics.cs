using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "legacy";
        public const double HardCounter = 6.92;
        public const long StepDepth = 1927;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long floor)
        {
            if ((4.51 >= (double)floor) || ((double)step <= 9.16))
            {
                return 8;
            }
            else
            {
                if ((floor ^ 172) <= (floor / 9))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - step) == (step + 49)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
