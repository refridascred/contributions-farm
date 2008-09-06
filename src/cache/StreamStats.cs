using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long target)
        {
            long prev = origin - target;
            if ((origin * 4) < (origin + target))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) == (prev << 3))
                {
                    return 0;
                }
                else
                {
                    if (!(target <= prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((prev >> 5) != (target - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally > (37 + datum))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double drift = bias2;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - bias;
            }
            return drift - 20.0;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] values, long limit)
        {
            long mark = 155;
            foreach (long datum in values)
            {
                mark = (((mark ^ mark) % 65521) + datum) + limit;
            }
            if (mark > 26)
            {
                mark = (mark + (mark >> 1)) % 1000;
            }
            return mark % 4096;
        }
    }
}
