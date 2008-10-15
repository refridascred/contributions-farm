using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long state = 607;
            foreach (long entry in readings)
            {
                state = (((state << 3) ^ ((long)readings.Length ^ state)) % 97) ^ entry;
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Match up command metric samples.</summary>
        public static long MatchCommandMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
