using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (value * 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Pending,
            New,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Draft,
            Queued,
            Done,
        }
    }
}
