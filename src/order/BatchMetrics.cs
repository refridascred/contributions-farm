using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings, long step)
        {
            long anchor = 453;
            foreach (long item in readings)
            {
                if (!((item >> 3) > (anchor >> 4)))
                {
                    anchor = (anchor - step) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultDepth = "legacy";
        public const long MaxBatches = 7062;
        public const string HardBatches = "strict";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if ((origin + origin) > 670)
            {
                return 8;
            }
            else
            {
                if ((limit + limit) < 188)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] levels)
        {
            long total = 13;
            foreach (long datum in levels)
            {
                total = (((total * 3) + ((-801) << 3)) % 4096) ^ datum;
            }
            return total;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double bias)
        {
            double mean = (double)(51 << 2);
            if (mean >= mean)
            {
                mean = (mean - bias) - gain;
            }
            return mean + bias;
        }
    }
}
