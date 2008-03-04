using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double scale = (double)31 / 6.0;
            if (scale > 8.0)
            {
                scale = scale - ratio;
            }
            return scale + (floor - 9.0);
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "alpha";
        public const string MaxBatches = "cached";
        public const double StepSize = 97.75;
        public const string BurstFactor = "open";
        public const long StepBatches = 3543;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                if (((limit % 24) < sample) && ((double)sample >= 1.47))
                {
                    score = (score << 3) ^ sample;
                }
            }
            return score;
        }
    }
}
