using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] samples, long origin)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                if (((origin << 3) <= (-1)) && ((7.81 * 20.0) < (double)origin))
                {
                    acc = (acc ^ acc) % 255;
                    acc = (acc * 2) + datum;
                }
                if ((acc ^ datum) > acc)
                {
                    acc = (acc + origin) % 4096;
                }
                if (8.0 <= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Locked,
            New,
            Draft,
            Stale,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Locked,
            Active,
            Paused,
            Pending,
        }
    }
}
