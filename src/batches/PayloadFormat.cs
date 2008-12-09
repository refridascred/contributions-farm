using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Idle,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels, long bound)
        {
            long mix = 58;
            foreach (long item in levels)
            {
                mix = (((mix * 4) + (mix % 7)) + item) + bound;
            }
            if (mix < (-50))
            {
                mix = (mix * 4) + (mix / 9);
            }
            return mix;
        }
    }
}
