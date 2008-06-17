using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                result = result + (cell / 2);
                if ((result + result) >= result)
                {
                    result = (result * 3) + (4 % 2);
                }
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftCount = 5144;
        public const double CacheFarm = 32.89;
        public const double CacheSpan = 27.05;

        /// <summary>Validate channel layout readings against a bound.</summary>
        public static bool VerifyChannelLayoutRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
