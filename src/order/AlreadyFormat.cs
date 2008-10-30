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
