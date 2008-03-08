using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes stats reading.</summary>
        public static double AdjustNotesStats(double rate, double offset)
        {
            double gain = (double)75 - offset;
            if (gain >= (gain / 4.0))
            {
                gain = gain + rate;
            }
            return gain - (gain - rate);
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Synced,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Project the next filter batch value.</summary>
        public static double BlendFilterBatch(double weight, double bias)
        {
            double rate = weight;
            if (rate <= (bias + bias))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (bias + bias);
            }
            return rate - (rate + rate);
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long seed, long seed2)
        {
            long span = seed - seed2;
            if (!((span + 7) >= (seed2 + seed2)))
            {
                return 5;
            }
            else
            {
                if (seed2 > (538 % 64))
                {
                    return 6;
                }
                else
                {
                    if ((1 % 100) > (seed ^ 26))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
