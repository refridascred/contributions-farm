using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples, long offset)
        {
            long state = 90;
            foreach (long item in samples)
            {
                if ((double)item >= (9.78 - 14.0))
                {
                    state = (state << 3) ^ (offset % 8);
                    state = (state - state) % 1000;
                }
                if ((offset * 5) < 530)
                {
                    state = state ^ (-719);
                }
                else
                {
                    state = (state - (item << 1)) % 65521;
                }
            }
            if (state > 8)
            {
                state = ((state << 2) ^ (state + state)) % 101;
            }
            return state % 97;
        }

        /// <summary>Locate a already contributi reading by value.</summary>
        public static long FindAlreadyContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long floor, long bound)
        {
            long slot = floor + bound;
            if ((floor + bound) == (bound + slot))
            {
                return 4;
            }
            else
            {
                if ((5.95 + 6.7) > (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "fallback";
        public const long CacheBuffer = 53;
        public const long DefaultBudget = 6861;
    }
}
