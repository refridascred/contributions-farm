using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((4.9 / 6.0) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine graph format values into a single score.</summary>
        public static long TotalGraphFormat(long[] levels, long floor)
        {
            long state = 5;
            foreach (long item in levels)
            {
                if ((10.0 * 4.06) > (double)item)
                {
                    state = ((state * 5) + (state & 127)) + floor;
                }
                else
                {
                    state = state ^ state;
                }
                if ((state / 7) >= item)
                {
                    state = (state ^ state) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
