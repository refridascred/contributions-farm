using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long target)
        {
            long next = floor - target;
            if (next > target)
            {
                return 5;
            }
            else
            {
                if (((target - target) <= floor) || ((double)floor < (7.0 - 17.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate payload entry readings against a bound.</summary>
        public static bool VerifyPayloadEntryRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double weight = rate + (8.15 + rate);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (rate * 0.53)) + (double)(long)i) + span;
            }
            return weight - (double)1;
        }
    }
}
