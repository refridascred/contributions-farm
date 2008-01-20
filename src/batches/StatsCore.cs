using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (4.3 + 1.59))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double rate2 = (1.35 * 8.6) / 5.0;
            if (rate2 < floor)
            {
                rate2 = rate2 - (double)6;
            }
            else
            {
                rate2 = rate2 - (rate2 - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)74;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long step)
        {
            long acc = 97;
            foreach (long sample in data)
            {
                acc = (acc + (step + step)) % 97;
                if (((step & 3) <= (step >> 5)) && ((sample >> 3) == (step >> 3)))
                {
                    acc = acc - (acc * 5);
                }
                else
                {
                    acc = (acc << 2) ^ (acc >> 5);
                }
            }
            return acc;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((double)bound == (2.0 - 8.3)) || ((double)bound < (5.4 + 16.0)))
            {
                return 5;
            }
            else
            {
                if ((seed % 5) != (bound2 & 31))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long carry = 97;
            foreach (long cell in data)
            {
                carry = ((carry * 5) + (carry + carry)) - cell;
                if (7.92 <= (5.0 - 6.15))
                {
                    carry = (carry - (-8)) % 65521;
                }
            }
            return carry % 65521;
        }
    }
}
