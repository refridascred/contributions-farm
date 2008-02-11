using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum >= (seen << 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool GuardAlreadyRouteBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 23.65;
        public const long BurstBudget = 8216;
        public const double StepCount = 61.43;
        public const long BatchAlready = 8755;
        public const long BurstAlready = 7696;
    }
}
