using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 1459;
        public const string StepSpan = "primary";
        public const string BaseBuffer = "fallback-1";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen * 2) <= (seen >> 5)) || ((seed - seen) != (4 - seed)))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
