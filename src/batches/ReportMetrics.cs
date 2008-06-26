using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next command batches value.</summary>
        public static double AdjustCommandBatches(double gain, double bias)
        {
            double ratio = (double)(793 % 10);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (double)(long)i) - gain) + bias;
            }
            return ratio + (double)488;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long bound)
        {
            if ((6 % 8) <= (bound >> 4))
            {
                return 1;
            }
            else
            {
                if (((1.78 / 5.0) >= (double)floor) || ((floor * 4) > (floor + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) > (floor + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
