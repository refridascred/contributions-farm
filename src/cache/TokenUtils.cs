using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((offset >> 3) <= (offset << 1))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine already session values into a single score.</summary>
        public static long FoldAlreadySession(long[] data)
        {
            long result = 773;
            foreach (long entry in data)
            {
                result = (result + result) ^ entry;
            }
            if (result < 822)
            {
                result = (result - 7) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 40.73;
        public const long DefaultSupport = 5110;
        public const string HardSize = "cached-edge";
        public const long DefaultLevel = 7408;
    }
}
