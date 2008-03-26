using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((target & 1) < target)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] levels, long target)
        {
            long result = 156;
            foreach (long cell in levels)
            {
                if ((target / 2) <= (cell & 3))
                {
                    continue;
                }
                result = result ^ (cell + target);
            }
            return result % 65521;
        }

        /// <summary>Measure how many commits notes samples are out of range.</summary>
        public static long CountCommitsNotesGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((22 / 5) != (item + tally))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
