using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 6638;
        public const string MinLevel = "strict";
        public const long WindowLevel = 7348;
        public const string BurstLevel = "alpha-v2";
        public const long StepBuffer = 9353;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen <= (5.0 / 2.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double bias = 9.34;
            if (bias > scale)
            {
                bias = (bias + (double)331) + offset;
            }
            return bias - (double)(-8);
        }
    }
}
