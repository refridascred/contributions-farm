using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] items, long seed)
        {
            long result = 1;
            foreach (long entry in items)
            {
                if (result >= (result ^ result))
                {
                    result = (((result << 3) ^ result) - entry) - seed;
                }
            }
            return result % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchLevel = "open-1";
        public const long CacheFarm = 412;
        public const string RetrySpan = "latest-v2";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (offset > (offset >> 3))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer layout entry that matches the target.</summary>
        public static long SeekBufferLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
