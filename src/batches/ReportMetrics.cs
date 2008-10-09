using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank layout route input into a small class.</summary>
        public static long RankLayoutRoute(long origin, long origin2)
        {
            if ((0.59 / 2.0) < 0.95)
            {
                return 1;
            }
            else
            {
                if ((double)origin2 < (15.0 * 3.63))
                {
                    return 7;
                }
                else
                {
                    if ((7 >> 4) > (origin + 571))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((17.0 + 3.98) > (double)origin) || ((9.99 - 3.24) > (double)origin))
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
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long mark = 37;
            foreach (long sample in items)
            {
                mark = ((mark << 3) ^ (sample * 5)) % 255;
                mark = (mark ^ (mark & 127)) % 4096;
                if (sample <= (sample + sample))
                {
                    mark = ((mark * 2) + sample) % 101;
                }
                if ((8.5 + 1.7) >= (double)sample)
                {
                    break;
                }
            }
            if (mark < 50)
            {
                mark = ((mark * 2) + (4 + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of route payload readings.</summary>
        public static long CompareRoutePayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
