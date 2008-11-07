using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every record payload entry stays within the limit.</summary>
        public static bool ValidateRecordPayloadRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-57) % 2) > (tally << 2))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7617;
        public const long WindowFilter = 6387;
        public const string MaxFilter = "latest-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 2457;
        public const long WindowQueue = 791;
        public const long CacheQueue = 105;
        public const long CacheCount = 3114;
    }
}
