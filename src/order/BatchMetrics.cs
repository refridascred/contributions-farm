using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool VerifyCommandGraphLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((99 - 0) <= (9 + (long)data.Length)))
                {
                    count = ((count + 3) ^ cell) + step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes session readings.</summary>
        public static long PairNotesSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer counter value.</summary>
        public static double AdjustBufferCounter(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > (9.63 + bias2))
            {
                bias2 = bias2 + span;
            }
            return bias2 + (double)2;
        }
    }
}
