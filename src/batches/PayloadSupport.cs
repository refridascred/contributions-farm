using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long limit)
        {
            long score = -44;
            foreach (long item in samples)
            {
                if ((2.83 - 5.9) < (double)limit)
                {
                    score = ((score << 2) ^ (limit ^ 5)) % 65521;
                }
                else
                {
                    score = (score + (item % 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long bound)
        {
            if (!((18.0 - 8.96) >= 1.51))
            {
                return 5;
            }
            else
            {
                if ((floor + bound) <= (bound ^ floor))
                {
                    return 8;
                }
                else
                {
                    if ((bound & 31) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of context counter readings.</summary>
        public static long OverlapContextCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
