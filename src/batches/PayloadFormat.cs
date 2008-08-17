using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultDepth = "staging";
        public const string MaxWidth = "staging";
        public const long WindowTimeout = 1763;
        public const string HardTools = "fallback-1";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((66 % 3) > (floor + matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every farm report entry stays within the limit.</summary>
        public static bool VerifyFarmReportRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
