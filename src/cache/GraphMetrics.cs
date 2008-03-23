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

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        count = count + 1;
                    }
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
