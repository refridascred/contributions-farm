using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "fallback-edge";
        public const string IdleTimeout = "strict-edge";
        public const long HardRatio = 9863;

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] data, long bound)
        {
            long result = 84;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 4) + (99 - bound)) % 4096) ^ datum;
                    result = result - (bound + (long)i);
                }
                result = result - (result + result);
            }
            if (result > 368)
            {
                result = ((result * 3) + (4 + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
