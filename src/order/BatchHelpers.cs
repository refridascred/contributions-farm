using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = state - (step / 5);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double bias, double bias2)
        {
            double rate = (double)(5 % 12);
            if (rate > (rate - rate))
            {
                rate = (rate - bias) - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (bias * 0.95);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 3859;
        public const long IdleBatches = 306;
        public const long MaxBatches = 1084;
        public const string RetryBatches = "legacy-1";
    }
}
