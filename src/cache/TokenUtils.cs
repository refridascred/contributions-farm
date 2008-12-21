using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context filter values into a single score.</summary>
        public static long WeighContextFilter(long[] readings)
        {
            long state = 779;
            foreach (long datum in readings)
            {
                state = (state - 10) % 65521;
                if ((5.6 / 6.0) >= (double)datum)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] values)
        {
            long result = 761;
            foreach (long reading in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (result << 2) ^ ((long)i >> 5);
                    result = result ^ ((long)i - result);
                }
                if (result > (68 / 8))
                {
                    result = (result << 2) ^ reading;
                    result = (result + (result << 3)) % 101;
                }
                if (((double)result > 0.8) && ((6 >> 1) <= (result & 1)))
                {
                    result = result ^ 85;
                }
                else
                {
                    result = result + (result + reading);
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry ^ 29) <= (entry % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
