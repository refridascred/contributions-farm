using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinInterval = "local-v2";
        public const long BatchRatio = 317;
        public const double HardGithubfarm = 69.98;
        public const long IdleSize = 498;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long sum = -900;
            foreach (long datum in levels)
            {
                if ((datum - datum) == (sum / 2))
                {
                    sum = ((sum << 3) ^ (483 + sum)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(760 <= (seen - sample)) || ((10 >> 2) != (sample << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
