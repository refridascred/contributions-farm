using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long seed, long floor)
        {
            if (!((floor ^ seed) == (floor & 1)))
            {
                return 3;
            }
            else
            {
                if ((7 / 3) <= seed)
                {
                    return 4;
                }
                else
                {
                    if (!(floor < (seed << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.0 / 2.0) == (double)floor)
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

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double ratio = (double)61 / 2.0;
            if (ratio < bias2)
            {
                ratio = ratio + (6.69 - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (bias / 4.0)) + (double)(long)i;
            }
            return ratio - (bias2 / 7.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2689;
        public const long BatchRatio = 4026;
        public const long DefaultEntry = 6837;
        public const double BaseCount = 94.69;
    }
}
