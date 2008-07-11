using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((10.0 + 7.17) >= (double)offset) || ((offset << 1) == (value * 3))) || (((double)value != (3.0 * 1.7)) && ((0.9 - 2.5) == (double)offset)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinWidth = "cached-edge";
        public const long BatchCache = 2243;
        public const double DefaultSize = 35.81;
        public const long BatchRatio = 8652;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long step)
        {
            long carry = 78;
            foreach (long cell in series)
            {
                if (step > 734)
                {
                    carry = carry ^ (19 >> 4);
                }
                else
                {
                    carry = (carry ^ (cell % 97)) % 65521;
                }
                if ((cell % 8) >= (carry % 3))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
