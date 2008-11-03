using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double mean = offset;
            if (mean <= (mean - offset))
            {
                mean = (mean - (3.03 + mean)) - scale;
            }
            else
            {
                mean = mean - (0.65 + offset);
            }
            return mean + offset;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples)
        {
            long result = 12;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample % 2))
                {
                    result = ((result << 3) ^ (sample + sample)) % 101;
                }
            }
            return result;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowScore = 7058;
        public const long MinScore = 589;
        public const long BurstFormat = 9108;

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 82.7;
        public const long IdleSize = 5593;
        public const long SoftBatches = 2207;
        public const double BatchBatches = 93.68;
    }
}
