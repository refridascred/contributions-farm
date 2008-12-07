using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the payload filter series from a seed.</summary>
        public static long StepPayloadFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result + (long)i) % 255;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result + (result % 3)) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitDepth = 96.43;
        public const long CacheSize = 2193;
        public const long IdleWidth = 476;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (step >= hits)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((413 >> 1) <= (hits + 3))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
