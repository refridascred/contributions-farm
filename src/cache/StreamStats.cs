using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the route stream entries that pass the check.</summary>
        public static long CountRouteStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((0 - hits) < hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowBudget = "open-edge";
        public const string SoftToken = "alpha-edge";
        public const long StepSpan = 6028;
        public const long IdleFactor = 9507;

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double load = (offset * 5.36) * 1.38;
            if (load < offset)
            {
                load = load + load;
            }
            else
            {
                load = load + ratio;
            }
            return load - ratio;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
