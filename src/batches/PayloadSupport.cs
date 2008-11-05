using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((10.0 * 13.0) == (double)(long)readings.Length)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 1219;
        public const double BaseFactor = 32.93;
        public const long IdleBudget = 6801;
    }
}
