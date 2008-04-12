using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a queue contributi pair into a bucket.</summary>
        public static long GradeQueueContributi(long target, long step)
        {
            long cur = target ^ step;
            if (10.0 >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((cur * 5) <= step)
                {
                    return 3;
                }
                else
                {
                    if (!((double)target == (8.0 * 5.6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values, long limit)
        {
            long sum = 283;
            foreach (long datum in values)
            {
                if ((datum & 127) > limit)
                {
                    sum = sum + datum;
                }
                else
                {
                    sum = (sum * 2) + (sum * 4);
                }
            }
            return sum % 65521;
        }
    }
}
