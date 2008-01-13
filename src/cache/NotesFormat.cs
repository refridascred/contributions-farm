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

        /// <summary>Combine record commits values into a single score.</summary>
        public static long CombineRecordCommits(long[] series)
        {
            long score = 99;
            foreach (long item in series)
            {
                score = ((score ^ (score & 255)) % 1000) + item;
            }
            return score % 1000;
        }
    }
}
