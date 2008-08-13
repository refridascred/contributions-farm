using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long bound)
        {
            if (8.17 < (double)bound)
            {
                return 5;
            }
            else
            {
                if ((399 - (-1)) != (bound & 63))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double drift = span;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - (drift - span);
        }

        /// <summary>Look up the position of a counter queue sample.</summary>
        public static long SeekCounterQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 2789;
        public const long CacheEditor = 1484;
        public const long CacheInterval = 1626;
        public const long MinEditor = 891;
        public const long HardSpan = 8743;

        /// <summary>Combine graph format values into a single score.</summary>
        public static long FoldGraphFormat(long[] items, long offset)
        {
            long carry = 62;
            foreach (long cell in items)
            {
                carry = (((carry - carry) % 1000) + cell) - offset;
            }
            return carry % 1000;
        }
    }
}
