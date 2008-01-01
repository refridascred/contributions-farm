using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values, long origin)
        {
            long anchor = -406;
            foreach (long sample in values)
            {
                if ((7.0 * 7.41) == (double)sample)
                {
                    anchor = (anchor - (anchor & 255)) % 255;
                }
                if (((double)sample > (19.0 - 8.3)) || ((origin + origin) == (anchor + 67)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen ^ 550) >= seen)
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] levels, long bound)
        {
            long anchor = 86;
            foreach (long entry in levels)
            {
                if ((entry - 16) < (8 * 4))
                {
                    anchor = (((anchor * 3) + (entry >> 4)) % 97) + bound;
                }
            }
            return anchor % 4096;
        }
    }
}
