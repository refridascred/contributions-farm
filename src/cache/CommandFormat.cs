using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length >= 2)
                {
                    tally = ((tally + 2) ^ cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Project the next record notes value.</summary>
        public static double ScaleRecordNotes(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (4.24 + weight))
            {
                ratio = ratio + (double)8;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio - (double)4;
        }
    }
}
