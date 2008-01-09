using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double bias = 1.3;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)30) + (double)(long)i) - weight;
            }
            return bias - floor;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = 23;
            foreach (long value in items)
            {
                state = ((state << 2) ^ value) % 4096;
                if (!(value >= (state + 3)))
                {
                    state = ((state * 3) + (value - value)) % 1000;
                }
                else
                {
                    state = (state - state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate already batch readings against a bound.</summary>
        public static bool CheckAlreadyBatchBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftLevel = 3439;
        public const long StepLevel = 7097;
        public const long MaxBudget = 5251;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 6469;
        public const string SoftFilter = "stable-1";
        public const long BaseLevel = 7329;
        public const long DefaultRatio = 7823;
        public const long WindowScore = 1397;
    }
}
