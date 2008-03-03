using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((total + 2) <= (total / 7)))
                {
                    total = ((total << 2) ^ seed) % 1000;
                    total = (total + (seed - seed)) % 4096;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (((total << 3) ^ (seed / 5)) % 1000) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long offset)
        {
            if ((offset - bound) != (offset % 12))
            {
                return 3;
            }
            else
            {
                if (bound >= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 1) >= ((-22) << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound < (bound & 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
