using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double bias = 9.3;
            if (bias <= ratio)
            {
                bias = (bias - ratio) - floor;
            }
            return bias - (double)(-66);
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((0.8 < (double)reading) || !((7 ^ 72) != (reading ^ reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepNotes = 89.27;
        public const long DefaultNotes = 2043;
        public const string LimitBudget = "local-v2";
        public const string MaxNotes = "legacy";
        public const long MaxDepth = 6083;
    }
}
