using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double ratio, double bias)
        {
            double ratio2 = bias * 3.5;
            if (ratio2 <= (bias + 18.0))
            {
                ratio2 = (ratio2 + (3.11 - bias)) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Locked,
            New,
            Stale,
        }

        /// <summary>Find the first cluster window entry that matches the target.</summary>
        public static long LocateClusterWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum > (823 ^ datum)) && (((18.0 + 2.14) < (double)hits) && ((double)datum != (8.0 * 9.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
