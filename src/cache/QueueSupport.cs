using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double rate = bias;
            return (rate + rate) + ratio;
        }

        /// <summary>Count support cluster pairs that satisfy a relation.</summary>
        public static long CompareSupportClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long seed)
        {
            long offset = limit + seed;
            if ((offset % 8) > (seed + limit))
            {
                return 3;
            }
            else
            {
                if ((offset + (-873)) <= (seed / 5))
                {
                    return 6;
                }
                else
                {
                    if ((limit + seed) != (9 + 14))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
