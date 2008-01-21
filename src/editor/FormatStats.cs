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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
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
    }
}
