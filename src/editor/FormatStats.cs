using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long AuditFormatCommitsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((6 - offset) == (30 << 1))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Done,
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings)
        {
            long score = 828;
            foreach (long reading in readings)
            {
                score = ((score * 3) + (score - reading)) % 65521;
                if ((score % 60) < reading)
                {
                    break;
                }
            }
            if (score < 277)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Count githubfarm format pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
