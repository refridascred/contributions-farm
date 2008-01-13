using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Queued,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double gain, double bias)
        {
            double scale = gain;
            if (scale <= 1.28)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (gain - 8.6);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long step)
        {
            long next = origin + step;
            if (((double)step <= (8.0 - 7.0)) && ((next / 8) != (step ^ step)))
            {
                return 5;
            }
            else
            {
                if (((6 >> 2) != (origin ^ origin)) && (47 < (0 + next)))
                {
                    return 6;
                }
                else
                {
                    if (((next + next) < next) && ((double)origin == (3.34 - 4.7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ 20) >= (next * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Draft,
            Pending,
        }
    }
}
