using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Derive the next entry session value from a seed.</summary>
        public static long StepEntrySession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((offset + offset) < offset) || (8.62 <= (double)sum))
                {
                    sum = ((sum * 4) + (offset / 7)) % 1000;
                    sum = (sum * 3) + (sum - sum);
                }
                else
                {
                    sum = (sum << 2) ^ (offset / 7);
                }
                sum = (sum - (sum + (long)i)) % 101;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)item > (8.0 / 6.0)) && (((seen * 4) != (seen ^ step)) && ((item * 4) >= (item & 7))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Idle,
            Dropped,
            Locked,
        }
    }
}
