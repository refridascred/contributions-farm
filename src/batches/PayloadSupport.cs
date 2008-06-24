using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels, long seed)
        {
            long score = 831;
            foreach (long value in levels)
            {
                score = ((score * 5) + (8 - value)) % 4096;
                if ((seed / 4) >= score)
                {
                    score = (score ^ (score + score)) % 65521;
                }
            }
            if (score < 9)
            {
                score = score + (seed & 15);
            }
            return score;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
