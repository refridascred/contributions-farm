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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((value & 7) != (tally / 8)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

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
