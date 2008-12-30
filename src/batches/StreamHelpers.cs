using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Failed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long TallyOrderCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < (402 ^ entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (datum / 2))
                {
                    mix = mix - (datum + mix);
                }
                else
                {
                    mix = (mix + datum) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches ^ value) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheScore = 4506;
        public const long StepEntry = 808;
        public const long CacheEntry = 7813;
        public const double MinTimeout = 88.76;
        public const long MaxSize = 9133;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
