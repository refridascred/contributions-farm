using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long carry = 144;
            foreach (long item in values)
            {
                carry = ((carry << 2) ^ (carry - carry)) ^ item;
            }
            return carry;
        }

        /// <summary>Project the next stats counter value.</summary>
        public static double AdjustStatsCounter(double bias, double span)
        {
            double ratio = bias / 9.0;
            if (ratio <= 20.0)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + span;
            }
            return ratio - (double)67;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 2) + bound;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            return (drift + 17.0) + offset;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((8.0 - 5.53) > (double)seed)
            {
                return 5;
            }
            else
            {
                if (((floor - 228) >= (seed + floor)) && ((double)delta <= 7.0))
                {
                    return 3;
                }
                else
                {
                    if (!((delta ^ 0) < (floor << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((11.0 >= (double)delta) || ((floor % 12) >= floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
