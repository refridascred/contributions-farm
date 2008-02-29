using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool CheckChecksRecordLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5486;
        public const double RetryBudget = 20.96;
        public const long LimitScore = 7218;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long offset)
        {
            long anchor = 211;
            foreach (long entry in readings)
            {
                anchor = (((anchor << 2) ^ (entry + 891)) % 255) + offset;
            }
            if (anchor < 114)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Paused,
            Done,
            Retry,
            Idle,
        }
    }
}
