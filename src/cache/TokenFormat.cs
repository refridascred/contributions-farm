using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((result & 127) != (result + (long)i)))
                {
                    result = result + (result >> 3);
                    continue;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
