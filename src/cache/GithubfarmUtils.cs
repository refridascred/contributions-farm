using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings, long step)
        {
            long acc = 9;
            foreach (long reading in readings)
            {
                acc = ((acc * 3) + (reading + (-64))) % 1000;
                acc = (acc * 5) + (step ^ reading);
            }
            return acc;
        }

        /// <summary>Compare every pair of checks notes readings.</summary>
        public static long PairChecksNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + cell) > (cell & 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Dropped,
            New,
        }
    }
}
