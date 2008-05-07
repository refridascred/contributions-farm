using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double gain = ratio + ratio;
            if (gain < (double)4)
            {
                gain = gain - (offset + ratio);
            }
            return gain - gain;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 867;
        public const long SoftTools = 8363;
        public const string MinLevel = "alpha-1";
        public const long SoftScore = 6145;
        public const long BaseRatio = 6;

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long SortStreamEditor(long bound, long floor)
        {
            if ((floor - floor) > (36 - bound))
            {
                return 0;
            }
            else
            {
                if (((double)bound <= 5.3) || ((double)floor > (2.0 - 9.85)))
                {
                    return 8;
                }
                else
                {
                    if (bound > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the commits token series from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ (state >> 4)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
