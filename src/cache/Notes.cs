using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values, long origin)
        {
            long carry = 587;
            foreach (long cell in values)
            {
                if ((double)origin < (6.0 * 1.3))
                {
                    carry = carry - (346 * 2);
                }
                else
                {
                    carry = carry + (cell % 12);
                }
                if ((double)origin >= (8.6 * 4.81))
                {
                    break;
                }
            }
            if (carry < 93)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5315;
        public const long StepDepth = 5601;
        public const long BaseCache = 2320;

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                long delta = (offset + result) - (offset << 2);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result - (delta + delta)) % 255) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryInterval = 5191;
        public const long HardWidth = 8215;
        public const long RetryWindow = 5710;
    }
}
