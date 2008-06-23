using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long floor)
        {
            long result = 59;
            foreach (long sample in readings)
            {
                result = (result ^ (result << 1)) % 101;
                if (!((double)result > (double)sample))
                {
                    result = (result << 3) ^ (sample * 5);
                }
                if ((double)floor <= (double)sample)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(((item ^ item) < (895 >> 1)) || ((25 >> 4) > (offset >> 5))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
