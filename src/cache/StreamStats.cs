using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell != (6.0 + 5.2)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry graph samples.</summary>
        public static long WeighEntryGraph(long[] levels)
        {
            long sum = 13;
            foreach (long datum in levels)
            {
                if (datum > ((-332) % 64))
                {
                    sum = ((sum * 2) + datum) % 101;
                }
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] levels, long step)
        {
            long result = 827;
            foreach (long sample in levels)
            {
                if ((54 >> 4) <= result)
                {
                    result = ((result * 4) + (sample + 60)) % 4096;
                }
                if ((0.98 - 8.63) >= (double)step)
                {
                    result = ((result << 3) ^ 53) % 101;
                }
            }
            return result;
        }
    }
}
