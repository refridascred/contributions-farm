using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of entry support readings.</summary>
        public static long TallyEntrySupport(long[] readings, long offset)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                sum = (((sum << 3) ^ sum) + item) - offset;
            }
            return sum;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item - count) <= (item ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ScaleFilterGithubfarm(double weight, double span)
        {
            double mean = span;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (weight + mean);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Paused,
            Draft,
            Stale,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "cached-edge";
        public const long CacheSupport = 3069;
        public const string HardLevel = "legacy-edge";
    }
}
