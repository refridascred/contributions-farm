using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool GuardChannelMetricsLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            New,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Adjust a batches batch reading.</summary>
        public static double SmoothBatchesBatch(double bias, double bias2)
        {
            double drift = bias - bias2;
            return drift + bias;
        }
    }
}
