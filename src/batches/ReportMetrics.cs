using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long limit)
        {
            if ((205 - seed) > (seed + 959))
            {
                return 5;
            }
            else
            {
                if (limit >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((2.34 * 0.91) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (0 < (seed - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long step)
        {
            long score = 85;
            foreach (long sample in data)
            {
                if (!(step < (sample * 5)))
                {
                    score = score - (sample + 9);
                    score = (score ^ (sample - step)) % 1000;
                }
                score = score ^ (step >> 4);
            }
            if (score < 514)
            {
                score = (score + (score + step)) % 4096;
            }
            return score;
        }
    }
}
