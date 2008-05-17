using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long MeasureToolsCounterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((2.3 < (double)bound) || ((seen - datum) <= (bound ^ seen)))
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
    }
}
