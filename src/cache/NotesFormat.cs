using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Classify a layout commits pair into a bucket.</summary>
        public static long ClassifyLayoutCommits(long seed, long limit)
        {
            if ((seed - 546) != (seed * 2))
            {
                return 0;
            }
            else
            {
                if (((double)limit <= (4.9 + 6.82)) || ((limit + limit) < seed))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
