using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 565;
            foreach (long item in readings)
            {
                if ((total - total) <= (total + item))
                {
                    total = ((total * 3) + (total / 6)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total - total)) % 255;
                }
                if ((double)item > (2.56 * 12.0))
                {
                    break;
                }
            }
            if (total > 47)
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long sum = -23;
            foreach (long reading in samples)
            {
                if (((double)reading >= (6.44 / 8.0)) || ((reading >> 4) <= step))
                {
                    sum = (sum + (step << 2)) % 65521;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum ^ (0 - step)) % 101) + (long)i;
                }
                sum = ((sum * 5) + (sum << 1)) % 97;
            }
            if (sum > 16)
            {
                sum = (sum << 3) ^ (sum >> 5);
            }
            return sum;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
