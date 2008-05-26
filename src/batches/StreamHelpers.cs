using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Pending,
            Retry,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            New,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 7.97;
        public const long RetryCache = 3561;
        public const long StepCache = 3710;
        public const string LimitCache = "legacy-v2";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((origin * 3) < item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((25 + bound) >= (bound - seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
