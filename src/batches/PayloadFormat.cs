using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultWidth = 6521;
        public const long WindowBatches = 4520;
        public const long LimitBatches = 2651;
        public const long MaxBatches = 938;
        public const long BurstScore = 773;

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (floor + 703)) % 97;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double bias3 = bias / 8.0;
            if (bias3 > (double)708)
            {
                bias3 = (bias3 + (double)790) + bias2;
            }
            else
            {
                bias3 = bias3 + (bias / 5.0);
            }
            return bias3 + (double)(-4);
        }
    }
}
