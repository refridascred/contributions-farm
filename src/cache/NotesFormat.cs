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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + count) > (count ^ count))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
