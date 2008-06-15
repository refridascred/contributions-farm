using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) >= ((-9) * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 6388;
        public const string WindowReport = "stable";
        public const long BatchReport = 9656;
        public const string IdleTimeout = "open-1";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
