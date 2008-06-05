using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double weight, double bias)
        {
            double rate = 2.45;
            return (rate - weight) + bias;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            long delta = target - step;
            if (target >= 92)
            {
                return 3;
            }
            else
            {
                if (delta <= (target ^ delta))
                {
                    return 4;
                }
                else
                {
                    if ((delta - step) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta - step) > (delta / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
