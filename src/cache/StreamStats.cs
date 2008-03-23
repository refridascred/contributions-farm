using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many window command samples are out of range.</summary>
        public static long AuditWindowCommandGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((double)item < 4.0) && ((double)count == (5.6 + 10.0))) && ((5.9 * 6.67) != (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!(acc >= ((long)i - (long)i)))
                {
                    acc = (acc ^ (acc >> 3)) % 97;
                }
                if (((long)i + offset) >= (acc ^ acc))
                {
                    acc = (acc - acc) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
