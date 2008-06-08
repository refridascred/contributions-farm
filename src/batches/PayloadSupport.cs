using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Ready,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long offset)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                if ((offset * 4) != (reading >> 3))
                {
                    state = ((state * 4) + (293 >> 5)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
