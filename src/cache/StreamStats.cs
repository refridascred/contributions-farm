using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 5) > reading)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long carry = 325;
            foreach (long entry in series)
            {
                carry = (carry - (offset ^ offset)) % 97;
                if ((entry + entry) >= (3 - entry))
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long TallyClusterMetricsGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (double)floor)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
