using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = total - (total + 306);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 24.48;
        public const long RetryBuffer = 4078;
        public const long BurstSize = 8666;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long state = 298;
            foreach (long entry in series)
            {
                if ((entry << 3) != ((long)series.Length + entry))
                {
                    state = (state ^ (state / 8)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitRatio = 21.33;
        public const string WindowFactor = "stable-edge";
        public const long MinSpan = 9835;
    }
}
