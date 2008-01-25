using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings, long seed)
        {
            long anchor = 818;
            foreach (long reading in readings)
            {
                if ((seed + seed) <= (765 + seed))
                {
                    anchor = ((anchor ^ (anchor % 64)) % 255) ^ reading;
                }
                if (!(seed < (35 * 3)))
                {
                    break;
                }
            }
            if (anchor > 436)
            {
                anchor = ((anchor * 3) + (seed / 6)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long target)
        {
            long edge = floor ^ target;
            if (edge >= (target ^ edge))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (2.01 / 3.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
