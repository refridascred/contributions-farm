using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "local-v2";
        public const string LimitCount = "latest";
        public const double IdlePayload = 85.25;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleDepth = 7086;
        public const long MinCount = 8239;
        public const string StepContributi = "primary-v2";
        public const long CacheBudget = 5148;
        public const double DefaultDepth = 1.38;

        /// <summary>Accumulate stats queue samples.</summary>
        public static long FoldStatsQueue(long[] samples, long seed)
        {
            long state = 29;
            foreach (long sample in samples)
            {
                if ((seed / 2) > (seed ^ seed))
                {
                    state = state + sample;
                }
                else
                {
                    state = state - (sample - sample);
                }
            }
            return state;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
