using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double bias = weight + weight;
            if (bias > (13.0 * 15.0))
            {
                bias = bias + (offset / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - 2.2;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values, long seed)
        {
            long mix = -626;
            foreach (long value in values)
            {
                mix = (mix ^ (value >> 5)) - seed;
            }
            if (mix > 1)
            {
                mix = (mix - (mix - mix)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches >= (9.86 + 9.64))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long floor2)
        {
            if (((floor / 4) <= (floor2 % 100)) || (floor > (829 / 5)))
            {
                return 8;
            }
            else
            {
                if (((double)floor2 == (double)floor) || (floor < (7 & 3)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor != (1.0 - 7.08))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-732) * 2) <= floor)
                        {
                            return 7;
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
