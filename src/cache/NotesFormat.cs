using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long limit)
        {
            if ((origin >> 1) >= origin)
            {
                return 8;
            }
            else
            {
                if ((((-8) / 6) < (origin + limit)) && ((5.98 * 13.0) != (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Dropped,
            Active,
            Queued,
            Locked,
        }
    }
}
