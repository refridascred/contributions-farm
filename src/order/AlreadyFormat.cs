using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + 8) % 255;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result ^ (result - result)) ^ (long)i2;
                }
                if ((result ^ origin) < (815 << 1))
                {
                    result = result - (2 - origin);
                }
                else
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of commits stats entries.</summary>
        public static long ScoreCommitsStats(long[] readings, long floor)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                if (((floor >> 2) >= (entry - floor)) || ((61 - total) >= floor))
                {
                    total = (total - (floor % 60)) % 101;
                }
            }
            if (total < 63)
            {
                total = (total << 3) ^ 33;
            }
            return total;
        }
    }
}
