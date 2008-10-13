using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Closed,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)target > (2.25 - 2.6))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}
