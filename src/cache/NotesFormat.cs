using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading <= 9.67) || ((reading + reading) == (reading - tally))) && ((double)reading < (double)4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long result = 54;
            foreach (long cell in data)
            {
                result = ((result ^ result) % 65521) - cell;
                if (626 < result)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
