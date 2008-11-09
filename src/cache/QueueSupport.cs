using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double rate = 1.4;
            return (rate + (floor / 3.0)) + weight;
        }

        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool GuardStatsSupportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metric queue samples.</summary>
        public static long PairMetricQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
