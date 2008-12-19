using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format layout counter forward.</summary>
        public static long DeriveFormatLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result + ((long)i / 5)) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxWidth = 6012;
        public const string BurstPayload = "strict-edge";
        public const long BurstRatio = 5052;
        public const long RetrySpan = 9194;
    }
}
