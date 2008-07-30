using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                if (!(reading < ((long)items.Length + reading)))
                {
                    acc = ((acc * 5) + (-1)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Audit context channel readings against a rule.</summary>
        public static long MeasureContextChannelOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (5.0 / 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample >> 2))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Rank batches cluster input into a small class.</summary>
        public static long SortBatchesCluster(long offset, long offset2)
        {
            if ((double)offset == (6.8 / 3.0))
            {
                return 4;
            }
            else
            {
                if (!((double)offset2 <= (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
