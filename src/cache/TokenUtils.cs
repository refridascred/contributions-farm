using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record checks readings against a rule.</summary>
        public static long AuditRecordChecksMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seed > datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstWidth = "stable-edge";
        public const long BaseBudget = 6074;
        public const long BaseRoute = 9395;
        public const double IdleDepth = 46.99;

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples)
        {
            long result = -666;
            foreach (long sample in samples)
            {
                if (!((266 + sample) > (sample * 5)))
                {
                    result = result ^ (38 - 4);
                }
                if ((7.56 < (1.73 / 8.0)) || ((result * 2) != (sample & 255)))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (result ^ result)) % 97;
            }
            return result;
        }
    }
}
