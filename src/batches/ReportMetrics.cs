using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 55;
            foreach (long value in series)
            {
                if ((mix * 4) < 91)
                {
                    mix = (((mix << 2) ^ (mix << 1)) % 97) ^ value;
                }
            }
            return mix;
        }
    }
}
