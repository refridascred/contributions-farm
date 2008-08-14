using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double gain = offset;
            if (gain > (16.0 + 11.0))
            {
                gain = gain + (weight * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (20.0 - 1.4)) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i / 8) < (long)i) || ((double)491 <= (double)limit))
                {
                    acc = (acc ^ (limit - limit)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long AuditStatsChecksOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((7.0 / 2.0) < (1.98 / 6.0))
                {
                    tally = ((tally + 2) - datum) - limit;
                }
            }
            return tally;
        }
    }
}
