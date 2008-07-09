using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double bias = (double)(5 - 463);
            if (bias < (double)(-62))
            {
                bias = ((bias + (double)500) - scale) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] values, long offset)
        {
            long result = 92;
            foreach (long datum in values)
            {
                result = (result * 2) + (datum + offset);
            }
            return result;
        }

        /// <summary>Locate a format counter reading by value.</summary>
        public static long LookupFormatCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
