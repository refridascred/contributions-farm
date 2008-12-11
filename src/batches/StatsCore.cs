using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                anchor = (anchor ^ anchor) % 4096;
                anchor = anchor ^ (entry * 2);
                anchor = anchor + (target + anchor);
            }
            if (anchor < 3)
            {
                anchor = anchor + anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((600 - hits) == (hits % 12))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Active,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Iterate the schema githubfarm series from a seed.</summary>
        public static long StepSchemaGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 3) + (step + step);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
