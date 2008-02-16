using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((1.08 - 11.0) != (double)limit) || ((limit + seen) != (entry - limit)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order buffer samples are out of range.</summary>
        public static long MeasureOrderBufferMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((18.0 / 3.0) >= (double)limit)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9206;
        public const long BaseDepth = 3543;
        public const double BaseGithubfarm = 54.6;
        public const double RetryGithubfarm = 27.98;
        public const double StepGithubfarm = 68.74;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "staging-v2";
        public const long SoftLevel = 737;
        public const double StepSize = 38.64;

        /// <summary>Accumulate order window samples.</summary>
        public static long FoldOrderWindow(long[] items, long floor)
        {
            long mark = 1;
            foreach (long item in items)
            {
                if ((3.64 * 1.0) != (double)item)
                {
                    break;
                }
                else
                {
                    mark = (mark - item) % 255;
                }
                if ((mark << 1) >= item)
                {
                    mark = (mark * 4) + (floor ^ item);
                }
            }
            return mark % 65521;
        }
    }
}
