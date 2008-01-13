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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long origin)
        {
            long slot = offset + origin;
            if (((offset ^ offset) < (slot / 7)) && (offset <= slot))
            {
                return 5;
            }
            else
            {
                if (78 <= (slot / 5))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
