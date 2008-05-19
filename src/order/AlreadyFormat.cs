using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + score) % 65521;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxLevel = 328;
        public const long CacheScore = 1751;
        public const long BaseReport = 2470;
        public const long SoftReport = 8295;
        public const double RetryReport = 22.16;

        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double scale = (offset + 8.6) / 8.0;
            if (scale < scale)
            {
                scale = (scale - scale) - rate;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (12.0 / 5.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long step)
        {
            long slot = seed ^ step;
            if (((slot * 3) < (0 / 8)) || ((double)step != (double)slot))
            {
                return 6;
            }
            else
            {
                if ((slot - slot) <= (step + slot))
                {
                    return 1;
                }
                else
                {
                    if ((2 & 3) >= (slot & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
