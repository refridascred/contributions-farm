using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Queued,
            Failed,
            Draft,
            Stale,
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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long step, long floor)
        {
            if ((step >> 4) >= floor)
            {
                return 7;
            }
            else
            {
                if ((step + floor) < floor)
                {
                    return 5;
                }
                else
                {
                    if (!((step & 7) != (step ^ 354)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - 798) <= (36 & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
