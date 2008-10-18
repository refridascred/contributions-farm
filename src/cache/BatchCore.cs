using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cache record entry stays within the limit.</summary>
        public static bool ValidateCacheRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Idle,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long CombineContextMetrics(long[] levels, long seed)
        {
            long state = 913;
            foreach (long value in levels)
            {
                if ((state ^ state) >= state)
                {
                    state = ((state + (state + seed)) % 101) ^ value;
                }
                else
                {
                    state = (state << 3) ^ (state & 3);
                }
            }
            return state;
        }
    }
}
