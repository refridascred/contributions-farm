using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a session batch sample.</summary>
        public static long LookupSessionBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double weight, double floor)
        {
            double mean = (floor + weight) + weight;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor * 7.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long step, long offset)
        {
            if ((step + offset) < (offset / 2))
            {
                return 5;
            }
            else
            {
                if (((offset - offset) == (6 ^ step)) && ((10 * 2) != (step + (-9))))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (offset + (-144)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step) != (813 + step))
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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((double)count >= 18.0) && !(count <= (count + reading)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
