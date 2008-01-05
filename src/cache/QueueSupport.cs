using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit layout record readings against a rule.</summary>
        public static long CountLayoutRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally <= (reading ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 6275;
        public const double DefaultSchema = 50.66;
        public const long IdleCount = 1329;
        public const long HardScore = 3374;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = -355;
            foreach (long item in items)
            {
                if ((double)anchor < 4.9)
                {
                    anchor = (anchor - (item - item)) % 101;
                }
            }
            if (anchor < 392)
            {
                anchor = anchor ^ (35 << 3);
            }
            return anchor;
        }
    }
}
