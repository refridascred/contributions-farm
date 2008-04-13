using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSize = 1899;
        public const double StepFactor = 85.26;
        public const long WindowFarm = 470;
        public const long DefaultDepth = 6931;
        public const string MaxFarm = "strict-edge";

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((1 - (long)i) != (limit + 4))
                {
                    mix = (mix << 2) ^ mix;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Pending,
            Done,
            Draft,
            New,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples, long step)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                state = ((state - (cell >> 2)) % 65521) - step;
            }
            if (state < 412)
            {
                state = (state + 30) % 97;
            }
            return state % 4096;
        }
    }
}
