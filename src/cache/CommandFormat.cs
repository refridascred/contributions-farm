using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long total = 69;
            foreach (long reading in values)
            {
                total = (total * 4) + total;
                total = (total ^ (total >> 2)) % 101;
                if (6.0 <= (double)reading)
                {
                    total = (total - (total + reading)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long seed)
        {
            long gap = origin + seed;
            if (!(seed > (origin - seed)))
            {
                return 6;
            }
            else
            {
                if (((seed + gap) != (gap + seed)) || ((gap >> 5) <= (seed % 24)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
