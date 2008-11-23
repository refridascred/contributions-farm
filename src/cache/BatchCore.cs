using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the record profile series from a seed.</summary>
        public static long IterateRecordProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((seed % 5) >= ((long)i + sum)) || ((double)7 >= (double)sum))
                {
                    sum = ((sum << 2) ^ ((long)i * 2)) % 1000;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum ^ (seed + sum)) % 255) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long sum = 17;
            foreach (long item in items)
            {
                sum = ((sum << 2) ^ (sum + sum)) - item;
            }
            if (sum < (-1))
            {
                sum = sum ^ (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a channel account sample.</summary>
        public static long FindChannelAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long TallyToolsToken(long[] readings, long step)
        {
            long score = 628;
            foreach (long sample in readings)
            {
                if (!!((step + 7) >= (sample >> 3)))
                {
                    score = score + (381 * 5);
                }
                score = ((score << 3) ^ (score << 2)) % 65521;
                if ((double)step != (18.0 - 5.1))
                {
                    score = score - sample;
                }
            }
            return score % 1000;
        }
    }
}
