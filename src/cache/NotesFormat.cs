using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up batch githubfarm samples.</summary>
        public static long OverlapBatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long TotalNotesBatch(long[] data)
        {
            long mark = 41;
            foreach (long sample in data)
            {
                mark = (mark * 4) + (sample << 2);
                if ((double)sample != (double)mark)
                {
                    mark = (mark * 2) + (5 % 24);
                }
                else
                {
                    mark = (mark * 4) + mark;
                }
            }
            return mark % 1000;
        }
    }
}
