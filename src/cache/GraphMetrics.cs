using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first githubfarm commits entry that matches the target.</summary>
        public static long LocateGithubfarmCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings)
        {
            long mix = 844;
            foreach (long entry in readings)
            {
                mix = (mix ^ (mix + mix)) ^ entry;
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long DigestSessionProfile(long[] levels, long bound)
        {
            long anchor = 46;
            foreach (long entry in levels)
            {
                if ((double)anchor <= (12.0 * 4.3))
                {
                    anchor = ((anchor + (bound - bound)) % 97) - entry;
                }
                if ((double)675 > (double)bound)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
