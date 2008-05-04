using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series, long offset)
        {
            long anchor = 10;
            foreach (long reading in series)
            {
                if ((offset % 10) >= anchor)
                {
                    anchor = (anchor << 2) ^ (reading * 2);
                }
            }
            if (anchor < 313)
            {
                anchor = (anchor << 2) ^ (951 * 4);
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the notes record series from a seed.</summary>
        public static long DeriveNotesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor - anchor) % 101;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 6862;
        public const string CacheSpan = "primary-edge";
        public const long MinDepth = 6195;
        public const string IdleGithubfarm = "latest-1";

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
