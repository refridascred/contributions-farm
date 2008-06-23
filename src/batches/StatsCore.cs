using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((mark * 5) > mark)
                {
                    mark = (mark - offset) % 65521;
                    mark = ((mark * 4) + (offset - offset)) % 101;
                }
                else
                {
                    mark = mark ^ 31;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double bias = gain;
            if (bias <= (double)8)
            {
                bias = (bias + bias) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (gain / 9.0)) + (double)(long)i;
            }
            return bias + (9.1 - gain);
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = total - (total + (long)i);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Done,
            Ready,
            Dropped,
            Synced,
        }
    }
}
