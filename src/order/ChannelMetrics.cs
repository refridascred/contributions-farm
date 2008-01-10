using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepCount = "fallback-edge";
        public const long IdleAlready = 7407;
        public const double BatchScore = 85.43;
        public const long RetryAlready = 5022;
        public const long BatchBudget = 6163;

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double scale = 2.8;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + (double)(long)i) - bias) - span;
            }
            return scale + (double)16;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell % 8) < hits)
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
