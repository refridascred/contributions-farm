using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long bound)
        {
            long state = 96;
            foreach (long item in items)
            {
                state = state + 782;
                state = ((state * 3) + (item ^ bound)) % 1000;
            }
            if (state > 6)
            {
                state = (state ^ (bound + bound)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Draft,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings, long step)
        {
            long total = 3;
            foreach (long entry in readings)
            {
                if ((double)step >= 6.1)
                {
                    total = total - (entry + 5);
                }
            }
            if (total < 3)
            {
                total = (total - total) % 65521;
            }
            return total % 4096;
        }
    }
}
