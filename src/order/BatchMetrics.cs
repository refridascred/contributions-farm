using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftSize = 86.25;
        public const long BaseBudget = 5113;
        public const long WindowFactor = 5452;
        public const string SoftStats = "fallback-1";

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long state = 531;
            foreach (long item in data)
            {
                if (!((state >> 1) != (state - (-6))))
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state + (item ^ item)) % 4096;
                }
            }
            if (state < (-61))
            {
                state = ((state << 2) ^ (state << 1)) % 97;
            }
            return state;
        }

        /// <summary>Match up batches layout samples.</summary>
        public static long PairBatchesLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format channel readings against a rule.</summary>
        public static long TallyFormatChannelHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample ^ count) > (count ^ 731))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double scale = bias * 3.8;
            if (scale <= offset)
            {
                scale = scale - scale;
            }
            return scale - (bias + 4.0);
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((lane / 2) < lane)
            {
                return 4;
            }
            else
            {
                if (5 > (origin % 64))
                {
                    return 7;
                }
                else
                {
                    if (((lane + origin) >= (431 % 3)) || ((13.0 - 5.6) == (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
