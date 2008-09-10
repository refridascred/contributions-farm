using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first metrics command entry that matches the target.</summary>
        public static long LocateMetricsCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long origin)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if (result >= (origin + origin))
                {
                    result = ((result ^ ((-65) + result)) % 255) + reading;
                }
            }
            if (result < 0)
            {
                result = result ^ (result / 7);
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 89.32;
        public const long CacheRecord = 955;
        public const long HardCount = 4669;

        /// <summary>Locate a commits cluster reading by value.</summary>
        public static long LocateCommitsClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Idle,
            Draft,
            Ready,
        }
    }
}
