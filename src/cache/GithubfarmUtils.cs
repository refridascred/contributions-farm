using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of farm context readings.</summary>
        public static long WeighFarmContext(long[] values, long bound)
        {
            long acc = 9;
            foreach (long sample in values)
            {
                if ((5 % 3) == (sample >> 2))
                {
                    acc = (acc + 91) - bound;
                }
            }
            return acc;
        }

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long AuditFormatRouteOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((target * 4) != (target << 2))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
