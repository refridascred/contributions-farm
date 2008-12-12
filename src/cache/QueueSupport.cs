using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long step)
        {
            long cur = seed - step;
            if ((cur % 24) > (step << 2))
            {
                return 0;
            }
            else
            {
                if ((seed << 2) >= (seed >> 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long TallySupportCacheMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((16.0 / 4.0) <= (double)(long)readings.Length)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long carry = 84;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading + carry)) % 1000;
            }
            return carry % 65521;
        }
    }
}
