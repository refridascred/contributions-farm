using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 68.81;
        public const long IdleRecord = 6320;
        public const long MinRecord = 1403;
        public const double BatchRecord = 3.62;
        public const string CacheScore = "fallback-edge";

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long step, long limit)
        {
            long span = step + limit;
            if ((span > limit) || (span <= (limit & 255)))
            {
                return 4;
            }
            else
            {
                if (((span + limit) > (span % 16)) || ((double)step <= (3.53 + 6.3)))
                {
                    return 0;
                }
                else
                {
                    if ((span / 4) == (step / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= 20)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next support notes value.</summary>
        public static double ScaleSupportNotes(double rate, double bias)
        {
            double mean = 8.06;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - 7.0) - (double)(long)i) - rate;
            }
            return mean + (bias + mean);
        }
    }
}
