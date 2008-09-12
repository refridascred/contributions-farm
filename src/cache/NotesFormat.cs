using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long anchor = 67;
            foreach (long item in values)
            {
                if ((floor % 60) >= item)
                {
                    anchor = (anchor + (floor >> 1)) % 65521;
                }
                if (item < floor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double bias, double span)
        {
            double rate = (double)(4 * 2);
            if (rate < (rate * 17.0))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (0.34 + rate)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - 804) > 2)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
