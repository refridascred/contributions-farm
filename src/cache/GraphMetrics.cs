using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((155 <= cell) && ((7.32 * 3.33) < (double)cell)) || ((double)seen != (19.0 - 3.5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long target)
        {
            long carry = 97;
            foreach (long value in values)
            {
                carry = (((carry ^ (9 ^ carry)) % 65521) - value) - target;
            }
            return carry;
        }

        /// <summary>Count the window context entries that pass the check.</summary>
        public static long CountWindowContextHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum % 12) <= count) || ((8.0 * 1.73) <= (double)target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target * 3) >= (anchor + 9))
                {
                    anchor = (anchor - (763 + anchor)) % 4096;
                }
                else
                {
                    anchor = anchor - ((long)i * 4);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor - (anchor / 8)) % 65521) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long result = 69;
            foreach (long cell in readings)
            {
                result = result + (result - 3);
                if ((cell * 4) <= (317 % 10))
                {
                    result = (result ^ (6 / 4)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
