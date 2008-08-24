using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardRatio = "alpha-v2";
        public const double IdleFormat = 92.94;
        public const string LimitRatio = "local-1";
        public const long WindowFormat = 1849;

        /// <summary>Iterate the entry contributi series from a seed.</summary>
        public static long StepEntryContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long offset)
        {
            if ((double)origin < (1.9 * 20.0))
            {
                return 7;
            }
            else
            {
                if ((double)offset > 5.4)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Closed,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Roll a route session counter forward.</summary>
        public static long DeriveRouteSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
