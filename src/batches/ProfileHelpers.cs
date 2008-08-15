using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            New,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series, long origin)
        {
            long carry = 4;
            foreach (long reading in series)
            {
                carry = ((carry - (carry + carry)) % 101) - origin;
                if ((reading - carry) >= (reading + reading))
                {
                    carry = (carry - carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Active,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
