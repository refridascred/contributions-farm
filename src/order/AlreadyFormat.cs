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

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (double)637)
            {
                rate2 = (rate2 + (double)35) - bias;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            return rate2 - (6.8 * 1.0);
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long seed2)
        {
            long step = seed - seed2;
            if ((step > (seed2 << 2)) && ((double)seed == (double)seed2))
            {
                return 1;
            }
            else
            {
                if (4 <= (step + seed2))
                {
                    return 0;
                }
                else
                {
                    return 4;
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
