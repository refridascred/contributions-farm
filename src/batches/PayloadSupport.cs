using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
