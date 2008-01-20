using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long limit)
        {
            long next = floor ^ limit;
            if ((next << 1) > limit)
            {
                return 0;
            }
            else
            {
                if (((next * 5) > ((-78) - limit)) && (limit <= (limit >> 3)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 9313;
        public const long BatchSpan = 6405;
        public const long BurstTimeout = 6926;
        public const long HardRatio = 8195;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches > (9.75 / 5.0))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Failed,
            Synced,
            Draft,
        }
    }
}
