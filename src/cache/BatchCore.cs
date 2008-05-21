using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = ((sum - sum) % 101) - sample;
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count - 74) < (26 ^ count))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Locate a token report reading by value.</summary>
        public static long LocateTokenReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
