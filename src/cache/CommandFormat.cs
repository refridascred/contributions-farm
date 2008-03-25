using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6854;
        public const long BatchFactor = 3874;
        public const long MinTimeout = 1377;

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

        /// <summary>Audit buffer format readings against a rule.</summary>
        public static long TallyBufferFormatHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((target + reading) > (990 - reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
