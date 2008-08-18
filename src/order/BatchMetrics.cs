using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCount = 32.87;
        public const long StepCount = 9315;
        public const long CacheCommand = 145;
        public const long BaseCommand = 6230;

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long StepPayloadOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + origin) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = (score + (52 % 100)) % 255;
                if (((score + score) == (score ^ score)) || ((score & 1) >= (-428)))
                {
                    score = (score * 4) + score;
                    score = ((score * 4) + (bound >> 3)) % 1000;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 4333;
        public const string HardOrder = "primary-v2";
        public const long DefaultInterval = 242;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
