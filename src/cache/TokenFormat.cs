using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long AuditRouteFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - datum) > (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Paused,
            Active,
        }
    }
}
