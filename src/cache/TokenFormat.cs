using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 39.37;
        public const string IdleBatch = "staging";
        public const long StepFactor = 6267;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long bound, long limit)
        {
            long diff = bound + limit;
            if (!((-98) <= (bound ^ diff)))
            {
                return 6;
            }
            else
            {
                if ((bound >> 1) > bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > 7.7)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream tools readings.</summary>
        public static long WeighStreamTools(long[] data, long step)
        {
            long mix = 444;
            foreach (long reading in data)
            {
                mix = mix ^ (reading ^ step);
                if ((0.46 / 9.0) >= (double)step)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
