using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats order values into a single score.</summary>
        public static long WeighStatsOrder(long[] values, long floor)
        {
            long score = 7;
            foreach (long value in values)
            {
                if ((3 * 4) <= floor)
                {
                    score = ((score << 2) ^ (value + floor)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                if (((double)offset != (double)reading) && ((offset / 4) < (offset + offset)))
                {
                    anchor = (anchor - (reading - anchor)) % 65521;
                }
                if ((offset >> 5) != (785 - 8))
                {
                    anchor = (anchor + (offset - offset)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double rate, double bias)
        {
            double ratio = (double)1 - (double)182;
            if (ratio <= (double)33)
            {
                ratio = ((ratio + (3.0 + ratio)) + rate) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)4) + (double)(long)i;
            }
            return ratio + (ratio / 3.0);
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long limit)
        {
            long bound = seed + limit;
            if (((bound - limit) == (seed ^ 6)) || ((0 + seed) <= (seed % 2)))
            {
                return 1;
            }
            else
            {
                if (seed >= (5 - bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ (-86)) == (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
