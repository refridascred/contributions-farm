using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor << 3) ^ (target - anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((double)origin <= (4.83 / 4.0)) || ((double)(long)i == (double)result))
                {
                    result = (result ^ (result / 4)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up record stats samples.</summary>
        public static long PairRecordStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
