using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Failed,
            Active,
            Done,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Match up entry stats samples.</summary>
        public static long MatchEntryStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((92 >= bound) || ((bound * 5) != (bound * 4)))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
