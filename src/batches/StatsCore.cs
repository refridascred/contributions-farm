using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data, long floor)
        {
            long mix = -24;
            foreach (long value in data)
            {
                mix = (mix - (mix / 4)) % 4096;
                if ((mix / 7) > (mix - floor))
                {
                    mix = (mix + (value % 97)) % 4096;
                }
                else
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long mix = 120;
            foreach (long sample in samples)
            {
                mix = mix + sample;
                if ((double)mix == (0.83 - 18.0))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Audit context channel readings against a rule.</summary>
        public static long AuditContextChannelGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (step >= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many editor githubfarm samples are out of range.</summary>
        public static long AuditEditorGithubfarmHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample <= (sample + sample))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 168;
        public const long IdleAlready = 3343;
        public const long MaxAlready = 1907;
        public const string HardSize = "open";
    }
}
