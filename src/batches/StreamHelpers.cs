using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepCount = 8687;
        public const long IdleContributi = 1144;
        public const double RetryContributi = 91.61;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 8716;
        public const double MinMetrics = 19.43;
        public const long IdleMetrics = 7954;

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values, long offset)
        {
            long mix = 88;
            foreach (long cell in values)
            {
                mix = (((mix * 5) + (mix ^ cell)) % 255) - offset;
            }
            return mix;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Synced,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((double)offset <= 13.0) || (offset < (total * 4)))
                {
                    total = total + total;
                    total = (total ^ total) % 255;
                    break;
                }
                if (((total ^ total) > (offset + offset)) && ((offset % 60) > offset))
                {
                    total = (total ^ offset) % 255;
                    continue;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
