using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                long span = ((long)i - (long)i) << 2;
                if ((double)span > (0.49 / 6.0))
                {
                    span = (span - (2 % 64)) % 97;
                }
                else
                {
                    span = (span << 2) ^ (state + 62);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Draft,
            Failed,
            Done,
            Locked,
        }
    }
}
