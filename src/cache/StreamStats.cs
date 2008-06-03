using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a context counter pair into a bucket.</summary>
        public static long RankContextCounter(long step, long seed)
        {
            if ((seed > (51 >> 2)) || ((step / 4) == (41 / 9)))
            {
                return 3;
            }
            else
            {
                if (step > (seed / 9))
                {
                    return 2;
                }
                else
                {
                    if (seed <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowSize = 8838;
        public const long SoftDepth = 2451;
        public const string IdleStats = "alpha-v2";

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double mean = 2.5;
            if (mean <= (mean + mean))
            {
                mean = ((mean + (mean * 2.56)) - ratio) - span;
            }
            else
            {
                mean = mean + (mean * 7.5);
            }
            return mean - (double)689;
        }
    }
}
