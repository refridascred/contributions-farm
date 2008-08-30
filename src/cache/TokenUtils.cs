using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long CombineStreamBatch(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if (((double)state < (double)datum) && ((datum & 7) <= state))
                {
                    state = ((state * 4) + state) % 65521;
                }
                else
                {
                    state = (state + (state ^ datum)) % 255;
                }
            }
            if (state > 6)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state;
        }
    }
}
