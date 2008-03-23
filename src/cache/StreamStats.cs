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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((value << 3) < (value << 1)) || ((1.75 * 7.0) > (double)value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
