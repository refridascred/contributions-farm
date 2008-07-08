using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Retry,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double load = span;
            if (load <= span)
            {
                load = load + (ratio + 4.49);
            }
            return load - span;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
