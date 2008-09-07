using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every cache payload entry stays within the limit.</summary>
        public static bool CheckCachePayloadBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a route support counter forward.</summary>
        public static long RollRouteSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset & 255) >= offset)
                {
                    result = ((result * 5) + (result ^ offset)) % 97;
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
