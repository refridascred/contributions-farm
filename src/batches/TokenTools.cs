using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long target)
        {
            long step2 = step + target;
            if (((target * 2) < target) && ((double)step <= (2.22 + 8.0)))
            {
                return 0;
            }
            else
            {
                if ((step2 << 2) >= (target % 3))
                {
                    return 4;
                }
                else
                {
                    if (step2 <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((seed + 4) != (seed + 5))
            {
                return 2;
            }
            else
            {
                if (((delta + limit) >= seed) || (delta >= (delta + delta)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
