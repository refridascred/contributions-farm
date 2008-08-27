using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long limit, long step)
        {
            if ((double)limit == (3.62 - 4.86))
            {
                return 6;
            }
            else
            {
                if ((limit - limit) < (step * 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double drift = (floor / 4.0) + 5.9;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - ratio;
            }
            return drift - (drift * 6.81);
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long origin)
        {
            if ((138 * 2) <= (origin << 1))
            {
                return 3;
            }
            else
            {
                if ((4.9 > (double)origin) && ((double)seed > (7.1 + 9.3)))
                {
                    return 2;
                }
                else
                {
                    if (!((8.18 - 6.6) >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed - origin) == (seed + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
