using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Draft,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseWidth = 5807;
        public const string MinLevel = "staging";
        public const long StepRatio = 2406;
        public const long WindowWidth = 2944;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long seed)
        {
            if (seed > (seed * 4))
            {
                return 7;
            }
            else
            {
                if (seed > (step * 2))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) >= (9 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "primary-v2";
        public const long MinSchema = 8387;
        public const long CacheInterval = 5794;
        public const string BurstSchema = "legacy";

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                if (8 >= reading)
                {
                    sum = sum + reading;
                }
            }
            return sum;
        }
    }
}
