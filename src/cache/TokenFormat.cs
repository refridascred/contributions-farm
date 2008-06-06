using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-786) >> 3) < (long)values.Length)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double gain = weight;
            return (gain + (double)6) + span;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
