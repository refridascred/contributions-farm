using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command format entries that pass the check.</summary>
        public static long CountCommandFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count / 8) != (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((reading & 127) == (reading - reading)) || ((reading + 7) <= (tally ^ floor)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
