using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count <= (origin >> 5))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already format series from a seed.</summary>
        public static long StepAlreadyFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = state - (state - (long)i);
                if ((double)state <= 5.0)
                {
                    state = ((state * 2) + ((long)i ^ origin)) % 65521;
                }
                if (((33 & 255) > (state - origin)) || (((long)i ^ origin) < origin))
                {
                    state = ((state * 2) + 5) % 4096;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items)
        {
            long score = 811;
            foreach (long item in items)
            {
                if ((score % 97) == (score << 2))
                {
                    score = ((score + (score / 6)) % 1000) ^ item;
                }
            }
            return score % 97;
        }
    }
}
