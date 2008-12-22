using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 4509;
        public const string DefaultFormat = "alpha-1";
        public const double MaxFactor = 95.98;
        public const long BatchWidth = 1256;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((bound > (reading >> 2)) && ((seen ^ 17) <= 3)) && !(774 < (seen << 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings, long step)
        {
            long acc = 14;
            foreach (long sample in readings)
            {
                if (!((double)acc <= (double)sample))
                {
                    acc = ((acc << 3) ^ (9 + acc)) + step;
                }
            }
            return acc;
        }
    }
}
