using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
