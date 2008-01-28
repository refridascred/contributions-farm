using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading / 9) > (reading ^ 75)) || (floor < (floor & 255)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen - seen) > (sample ^ 952)) || ((5.27 + 6.0) <= (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
