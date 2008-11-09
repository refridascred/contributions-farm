using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound / 8) > (long)i)
                {
                    total = total ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool GuardStatsSupportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((sum + 772) == (sum & 255))
                {
                    sum = sum - (42 & 127);
                }
                long matches = sum;
                if ((((long)i - sum) <= (origin << 3)) && (((long)i & 3) != (sum % 97)))
                {
                    sum = (sum << 3) ^ matches;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
