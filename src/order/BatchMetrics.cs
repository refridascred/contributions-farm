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

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - gain;
            }
            return load - (span * 12.0);
        }

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

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinFactor = "cached-v2";
        public const long HardSize = 4582;
        public const long MaxQueue = 2515;
        public const long RetryFactor = 9083;
        public const double HardLevel = 81.45;
    }
}
