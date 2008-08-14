using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseFactor = 40.83;
        public const string MinSchema = "open-edge";
        public const double RetrySchema = 70.96;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] values, long origin)
        {
            long sum = 760;
            foreach (long reading in values)
            {
                if (((double)reading == (double)origin) || ((sum & 15) != ((long)values.Length + 6)))
                {
                    sum = (sum + (reading >> 2)) % 97;
                }
                else
                {
                    sum = sum ^ (reading + 4);
                }
            }
            return sum % 65521;
        }
    }
}
