using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many format farm samples are out of range.</summary>
        public static long AuditFormatFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + hits) != (reading << 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 9241;
        public const string WindowSession = "fallback-1";
        public const long StepSession = 3617;
        public const long IdleSession = 3168;

        /// <summary>Accumulate buffer commits samples.</summary>
        public static long TotalBufferCommits(long[] values)
        {
            long anchor = 8;
            foreach (long entry in values)
            {
                anchor = ((anchor + (anchor & 15)) % 255) ^ entry;
                anchor = (anchor - (2 * 3)) % 97;
            }
            return anchor;
        }
    }
}
