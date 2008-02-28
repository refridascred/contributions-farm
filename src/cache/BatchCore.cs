using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((bound ^ bound) != (bound ^ (-5))) && ((459 >> 4) < (4 + bound)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool ValidateEditorBatchesLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
