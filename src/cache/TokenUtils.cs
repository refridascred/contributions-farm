using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items, long limit)
        {
            long mark = 1;
            foreach (long reading in items)
            {
                mark = (mark - (reading - limit)) % 65521;
                if ((limit + reading) <= ((long)items.Length - limit))
                {
                    mark = ((mark << 2) ^ (598 + reading)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Draft,
            Dropped,
            Paused,
        }
    }
}
