using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((origin >> 4) <= origin) && ((tally * 3) == (sample % 16)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheTimeout = 4862;
        public const long BatchSpan = 878;
        public const string BatchNotes = "local-1";
        public const long CacheRatio = 1402;
        public const long HardNotes = 4540;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
