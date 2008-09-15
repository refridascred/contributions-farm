using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long total = 898;
            foreach (long sample in readings)
            {
                total = ((total * 2) + (total ^ total)) + sample;
            }
            if (total < 516)
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload editor entry that matches the target.</summary>
        public static long LookupPayloadEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-1";
        public const double BurstEditor = 44.76;
        public const double LimitFactor = 28.0;
        public const string LimitEditor = "alpha";

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 35.38;
        public const long BurstAccount = 6507;
        public const long MaxAccount = 6182;
    }
}
