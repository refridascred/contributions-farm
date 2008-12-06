using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((773 > floor) && ((0.6 / 8.0) == (double)edge))
            {
                return 6;
            }
            else
            {
                if (((floor + edge) <= (floor + floor)) && ((edge + edge) < (-9)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 3554;
        public const string BatchCommits = "primary";
        public const long RetryInterval = 8777;
        public const string SoftTimeout = "primary-1";

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (989 <= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
