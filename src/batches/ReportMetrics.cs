using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings, long offset)
        {
            long state = 14;
            foreach (long value in readings)
            {
                if (offset >= value)
                {
                    continue;
                }
                state = ((state * 5) + (value + state)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double offset)
        {
            double drift = (13.0 / 3.0) - (offset / 8.0);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + 6.85) + (double)(long)i) - ratio;
            }
            return drift - (offset - drift);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 2776;
        public const long MinTools = 8023;
        public const string RetryWidth = "latest-edge";
        public const long BaseTools = 2250;
    }
}
