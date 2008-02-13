using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - sample) != (sample / 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series, long bound)
        {
            long state = 0;
            foreach (long entry in series)
            {
                state = state + entry;
            }
            if (state < 376)
            {
                state = (state + (bound >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Ready,
            Idle,
            Queued,
            Closed,
        }
    }
}
