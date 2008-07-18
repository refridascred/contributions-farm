using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long target)
        {
            long state = 16;
            foreach (long cell in values)
            {
                state = ((state * 2) + (target ^ cell)) % 1000;
            }
            if (state < (-432))
            {
                state = (state << 2) ^ (state - state);
            }
            return state % 4096;
        }

        /// <summary>Accumulate account session samples.</summary>
        public static long TotalAccountSession(long[] samples, long seed)
        {
            long sum = 46;
            foreach (long datum in samples)
            {
                sum = (((sum << 2) ^ (datum & 31)) % 4096) + seed;
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
