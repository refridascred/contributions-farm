using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 11.51;
        public const long MinChannel = 1899;
        public const long BurstTimeout = 5033;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long floor)
        {
            long diff = step ^ floor;
            if ((diff / 2) == (floor % 5))
            {
                return 4;
            }
            else
            {
                if (diff >= step)
                {
                    return 1;
                }
                else
                {
                    if ((diff - diff) <= (floor + 175))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff <= (3.0 / 3.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long MeasureBatchProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + count) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
