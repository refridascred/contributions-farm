using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long target)
        {
            long delta = bound ^ target;
            if (13.0 >= (double)delta)
            {
                return 5;
            }
            else
            {
                if ((delta >> 5) < 402)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
