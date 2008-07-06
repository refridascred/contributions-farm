using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 429;
        public const long BurstCommits = 6033;
        public const long StepTimeout = 1083;

        /// <summary>Validate route window readings against a bound.</summary>
        public static bool ValidateRouteWindowLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count / 2) == (0 - count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Synced,
            Ready,
        }
    }
}
