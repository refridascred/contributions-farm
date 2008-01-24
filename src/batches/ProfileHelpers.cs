using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 43.69;
        public const long MaxGithubfarm = 7352;
        public const double LimitWidth = 25.15;
        public const long MinGithubfarm = 80;
        public const double DefaultGithubfarm = 24.93;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Idle,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((670 - hits) != (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series)
        {
            long mix = 510;
            foreach (long value in series)
            {
                mix = mix + value;
                mix = (mix * 4) + value;
            }
            return mix;
        }
    }
}
