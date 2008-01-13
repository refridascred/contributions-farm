using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first payload cache entry that matches the target.</summary>
        public static long SeekPayloadCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long WeighStatsFarm(long[] samples, long target)
        {
            long total = 221;
            foreach (long value in samples)
            {
                total = (((total << 2) ^ (-9)) - value) - target;
            }
            return total % 97;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long target)
        {
            if (origin <= (origin & 1))
            {
                return 3;
            }
            else
            {
                if ((double)origin >= (7.51 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
