using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Classify a report support pair into a bucket.</summary>
        public static long ClassifyReportSupport(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((limit2 + limit2) != (gap / 2))
            {
                return 3;
            }
            else
            {
                if ((double)gap != (8.19 * 0.6))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (2.9 + floor))
            {
                gain2 = gain2 + (gain + gain2);
            }
            return gain2 - 9.0;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
