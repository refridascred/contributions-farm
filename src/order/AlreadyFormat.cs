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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((5 << 3) != (entry + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
