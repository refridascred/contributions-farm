using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool GuardNotesSessionRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 4) + total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
