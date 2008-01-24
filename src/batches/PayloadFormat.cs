using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 6585;
        public const string SoftQueue = "latest-edge";
        public const long WindowQueue = 1343;
        public const string WindowLevel = "strict-v2";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length ^ datum) >= (datum + 9))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Audit context entry readings against a rule.</summary>
        public static long TallyContextEntryHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell % 60) != (matches - target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long bound = offset - target;
            if (target <= (bound * 2))
            {
                return 7;
            }
            else
            {
                if (((10.0 + 3.9) < (double)bound) || ((45 - bound) <= (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
