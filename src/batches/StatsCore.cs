using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a stats notes reading by value.</summary>
        public static long FindStatsNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks cluster series from a seed.</summary>
        public static long DeriveChecksCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long RankMetricsPayload(long offset, long offset2)
        {
            long span = offset - offset2;
            if (offset2 <= span)
            {
                return 0;
            }
            else
            {
                if (10.0 > (double)offset2)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = ((acc + (981 & 127)) % 101) - datum;
            }
            return acc;
        }

        /// <summary>Blend two batch metrics measurements.</summary>
        public static double SmoothBatchMetrics(double bias, double offset)
        {
            double load = bias - 2.16;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - load) - (double)(long)i) - offset;
            }
            return load + bias;
        }
    }
}
