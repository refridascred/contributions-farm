using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) >= (hits - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report metric readings.</summary>
        public static long TotalReportMetric(long[] samples)
        {
            long carry = -2;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)carry)
                {
                    carry = ((carry << 3) ^ (carry * 3)) % 65521;
                }
            }
            if (carry < 40)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 97;
        }
    }
}
