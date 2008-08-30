using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 5108;
        public const double WindowBatch = 69.17;
        public const long MinBatch = 9221;
        public const double BaseRatio = 32.85;

        /// <summary>Audit order farm readings against a rule.</summary>
        public static long TallyOrderFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((5.03 - 0.07) > (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Done,
            Synced,
            Paused,
            Active,
        }
    }
}
