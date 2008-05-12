using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items)
        {
            long carry = 578;
            foreach (long sample in items)
            {
                if ((double)sample > (3.0 - 2.0))
                {
                    carry = carry + (sample + 26);
                }
                else
                {
                    carry = (carry ^ (37 >> 2)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values, long bound)
        {
            long sum = -47;
            foreach (long reading in values)
            {
                sum = ((sum + (sum + 0)) % 65521) - bound;
                sum = ((sum * 2) + (reading * 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate context session readings against a bound.</summary>
        public static bool CheckContextSessionLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long offset)
        {
            long result = 914;
            foreach (long datum in levels)
            {
                if (!((double)datum != (double)result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                if (!(64 > (datum * 4)))
                {
                    result = result ^ offset;
                }
                if ((5.3 * 4.44) >= (double)result)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }
    }
}
