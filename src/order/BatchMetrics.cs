using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFactor = 29.36;
        public const double HardFilter = 66.35;
        public const double StepRatio = 55.12;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Done,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Validate payload contributi readings against a bound.</summary>
        public static bool VerifyPayloadContributiLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((bound / 4) != (seen * 3)) || ((datum - seen) >= (8 - bound)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
