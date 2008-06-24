using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value - value) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultLevel = "staging-1";
        public const long BatchBatches = 1022;
        public const long HardBatches = 1588;
        public const long LimitBatches = 8536;

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long datum in readings)
            {
                mix = ((mix - (mix - mix)) % 101) - datum;
            }
            if (mix > 281)
            {
                mix = mix - limit;
            }
            return mix;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
