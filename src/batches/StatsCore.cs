using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double load = rate;
            if (load >= load)
            {
                load = load + bias;
            }
            else
            {
                load = load + (load / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (bias + rate);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            New,
            Paused,
            Closed,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((5.01 / 6.0) != (double)score)
                {
                    score = ((score << 2) ^ ((long)i - 3)) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long limit)
        {
            long step = origin - limit;
            if (((step % 97) == (step ^ 744)) || ((limit % 5) <= (-9)))
            {
                return 7;
            }
            else
            {
                if ((0 ^ step) != (limit - origin))
                {
                    return 2;
                }
                else
                {
                    if (!(origin > (limit << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin ^ origin) < origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
