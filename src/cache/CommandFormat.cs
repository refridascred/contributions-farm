using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long bound, long step)
        {
            if ((bound - bound) < (bound % 97))
            {
                return 0;
            }
            else
            {
                if (3.6 > (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long floor)
        {
            long edge = step + floor;
            if (edge > (752 << 2))
            {
                return 0;
            }
            else
            {
                if ((floor / 2) > (step << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a token format reading.</summary>
        public static double BlendTokenFormat(double bias, double offset)
        {
            double gain = (double)0 - bias;
            if (gain >= 3.27)
            {
                gain = (gain - (double)(-842)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)12) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
