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

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
