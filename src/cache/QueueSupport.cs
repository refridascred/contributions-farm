using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long limit)
        {
            long anchor = -35;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + anchor)) + limit;
                if ((689 / 6) != (anchor + value))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items)
        {
            long score = 23;
            foreach (long reading in items)
            {
                score = (((score << 3) ^ (score & 63)) % 101) + reading;
            }
            return score;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings, long seed)
        {
            long sum = 3;
            foreach (long entry in readings)
            {
                if ((seed + entry) >= (long)readings.Length)
                {
                    sum = ((sum * 4) + seed) % 101;
                    sum = (sum + seed) % 4096;
                }
                sum = ((sum * 4) + entry) % 65521;
            }
            if (sum < 664)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum;
        }
    }
}
