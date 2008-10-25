using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ (result - seed);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long MeasureBufferEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum / 6) < 64)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches < (entry + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double rate, double floor)
        {
            double bias = (double)(858 + 26);
            if (bias <= floor)
            {
                bias = bias + (double)32;
            }
            return bias - (rate + floor);
        }
    }
}
