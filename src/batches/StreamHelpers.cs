using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first notes command entry that matches the target.</summary>
        public static long LocateNotesCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long TallyFilterChecksHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits < origin) && ((origin >> 3) != (hits + origin))) && ((double)hits != (double)origin))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
