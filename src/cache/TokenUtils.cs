using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order layout sample.</summary>
        public static long LocateOrderLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((score >> 5) >= score)
                {
                    score = ((score * 3) + (score / 8)) % 97;
                    continue;
                }
                else
                {
                    score = (score << 3) ^ (score - score);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
