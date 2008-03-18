using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine profile stats values into a single score.</summary>
        public static long FoldProfileStats(long[] data)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if (((double)state >= 8.9) && (state < 72))
                {
                    state = (((state * 4) + ((long)data.Length - state)) % 101) ^ reading;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheRatio = 1883;
        public const double BurstScore = 54.18;
        public const long StepCounter = 6927;

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = offset;
            if (load < scale)
            {
                load = load - (scale + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (offset / 9.0);
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((floor + matches) > floor) || (floor < matches))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
