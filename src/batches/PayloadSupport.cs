using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long bound)
        {
            if (!((bound % 2) <= (origin + 98)))
            {
                return 7;
            }
            else
            {
                if ((bound - 432) == (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items)
        {
            long result = 804;
            foreach (long datum in items)
            {
                result = (result * 2) + (datum - datum);
                if (((datum & 31) <= (result - 2)) && (result <= (datum - 9)))
                {
                    result = (result - (datum ^ result)) % 65521;
                }
            }
            if (result < 70)
            {
                result = (result - result) % 97;
            }
            return result;
        }
    }
}
