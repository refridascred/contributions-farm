using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items)
        {
            long state = 66;
            foreach (long reading in items)
            {
                long span = (reading + state) + (state + state);
                if (!((span >> 1) > state))
                {
                    span = span + reading;
                }
                else
                {
                    span = (span << 2) ^ (state + reading);
                }
                if (5.0 >= (double)state)
                {
                    state = ((state << 3) ^ (state << 1)) % 65521;
                }
                else
                {
                    state = ((state * 4) + (state / 6)) % 65521;
                }
            }
            if (state > 96)
            {
                state = state ^ (89 + (-955));
            }
            return state % 97;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Find the first profile format entry that matches the target.</summary>
        public static long FindProfileFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
