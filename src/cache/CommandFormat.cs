using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a entry batches reading.</summary>
        public static double AdjustEntryBatches(double weight, double span)
        {
            double mean = (double)(8 + 4);
            if (mean <= (double)8)
            {
                mean = ((mean - (double)501) + weight) - span;
            }
            return mean - mean;
        }

        /// <summary>Roll a route window counter forward.</summary>
        public static long StepRouteWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = (score * 5) + score;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a window payload value against two limits.</summary>
        public static long RankWindowPayload(long seed, long target)
        {
            long bound = seed - target;
            if ((target > (target + bound)) && ((seed + seed) == (seed % 5)))
            {
                return 1;
            }
            else
            {
                if ((2 + bound) == (seed - 7))
                {
                    return 4;
                }
                else
                {
                    if ((7.3 + 8.71) != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target == (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
