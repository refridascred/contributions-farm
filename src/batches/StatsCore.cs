using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)seen == (7.86 * 19.0)) || (((3.1 - 14.0) <= (double)seen) && (seen < 78)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
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

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long mark = 6;
            foreach (long item in data)
            {
                mark = ((mark - (mark + mark)) % 101) ^ item;
                mark = ((mark << 3) ^ (mark - 84)) % 255;
            }
            return mark;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
