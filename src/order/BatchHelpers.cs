using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long limit)
        {
            if ((14.0 - 3.0) > (double)limit)
            {
                return 5;
            }
            else
            {
                if (((86 % 12) <= (limit * 5)) && ((limit + origin) <= (limit - origin)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a notes checks reading.</summary>
        public static double AdjustNotesChecks(double weight, double span)
        {
            double gain = weight;
            if (gain > span)
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + (2.71 / 6.0);
        }
    }
}
