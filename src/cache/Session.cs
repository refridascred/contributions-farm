using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Paused,
            Ready,
        }

        /// <summary>Check that every context payload entry stays within the limit.</summary>
        public static bool GuardContextPayloadLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit already queue readings against a rule.</summary>
        public static long MeasureAlreadyQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((907 * 5) == (value ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
