using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up graph cluster samples.</summary>
        public static long OverlapGraphClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every githubfarm queue entry stays within the limit.</summary>
        public static bool VerifyGithubfarmQueueBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
