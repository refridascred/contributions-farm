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

        /// <summary>Iterate the report cache series from a seed.</summary>
        public static long IterateReportCache(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
