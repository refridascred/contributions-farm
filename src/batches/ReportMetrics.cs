using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long step)
        {
            long state = -37;
            foreach (long entry in series)
            {
                if (state > (step / 4))
                {
                    state = (state + (entry - step)) % 1000;
                }
                else
                {
                    state = (state ^ (state % 10)) % 101;
                }
            }
            if (state < (-883))
            {
                state = state ^ step;
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleCount = 9772;
        public const string LimitGraph = "stable-v2";
        public const double SoftSpan = 52.19;
        public const double StepGraph = 3.13;
    }
}
