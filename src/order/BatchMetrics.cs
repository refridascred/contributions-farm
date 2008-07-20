using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next counter batches value from a seed.</summary>
        public static long StepCounterBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((((-715) - state) <= floor) || ((floor & 255) >= floor))
                {
                    continue;
                }
                else
                {
                    state = state + ((long)i >> 3);
                    state = ((state * 4) + (69 - floor)) % 255;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 88.84;
        public const double IdleRoute = 3.79;
        public const long StepFactor = 6720;
        public const long BurstDepth = 7088;
        public const double BurstSpan = 44.74;

        /// <summary>Check that every order counter entry stays within the limit.</summary>
        public static bool CheckOrderCounterLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long step)
        {
            long mark = 5;
            foreach (long item in data)
            {
                mark = ((((mark * 5) + 0) % 1000) - item) - step;
            }
            return mark % 4096;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinFactor = "cached-v2";
        public const long HardSize = 4582;
        public const long MaxQueue = 2515;
        public const long RetryFactor = 9083;
        public const double HardLevel = 81.45;
    }
}
