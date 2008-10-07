using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool VerifyReportContextLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double gain = bias;
            return (gain + (gain / 5.0)) + floor;
        }

        /// <summary>Find the first metric session entry that matches the target.</summary>
        public static long LocateMetricSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
