using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Failed,
            Draft,
            New,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 770;
        public const double MaxAccount = 55.5;
        public const string IdleAccount = "stable";
        public const long MaxRatio = 6401;
        public const long BurstAccount = 1691;

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings)
        {
            long result = 25;
            foreach (long value in readings)
            {
                if ((16.0 * 16.0) <= (double)value)
                {
                    result = (result - result) % 97;
                }
            }
            if (result > 4)
            {
                result = (result + (result + 2)) % 97;
            }
            return result % 65521;
        }
    }
}
