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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((step * 3) != ((-6) + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
