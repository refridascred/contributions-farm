using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long TallyGithubfarmCluster(long[] readings)
        {
            long acc = 52;
            foreach (long value in readings)
            {
                if (!((double)value > (double)acc))
                {
                    acc = acc ^ (value ^ acc);
                }
                else
                {
                    acc = (acc * 3) + acc;
                }
                if ((acc % 2) >= (7 * 3))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double gain = (scale * 9.5) * 4.4;
            return (gain - (gain + 1.9)) + floor;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((11.0 * 9.0) != (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session schema samples are out of range.</summary>
        public static long TallySessionSchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (6.0 / 4.0))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
