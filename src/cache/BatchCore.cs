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

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
