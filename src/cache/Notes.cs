using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of batch profile readings.</summary>
        public static long CompareBatchProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ acc;
                if (844 < (origin & 63))
                {
                    acc = (acc * 2) + (acc + acc);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= gain)
            {
                gain2 = gain2 - (bias + gain);
            }
            return gain2 - gain2;
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

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long bound)
        {
            long prev = limit - bound;
            if (!((bound + prev) >= (51 & 255)))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= prev)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
