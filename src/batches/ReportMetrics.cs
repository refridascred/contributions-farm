using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultInterval = "fallback";
        public const long RetrySpan = 4535;
        public const string BurstTimeout = "open";
        public const long HardMetrics = 2308;
        public const string MaxMetrics = "strict-v2";

        /// <summary>Look up the position of a notes layout sample.</summary>
        public static long FindNotesLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((48 ^ seed) > (long)i)
                {
                    mark = ((mark * 3) + ((long)i >> 1)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
