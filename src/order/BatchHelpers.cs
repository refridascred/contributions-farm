using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((step < (sample >> 3)) && (((step - sample) >= (sample + sample)) || ((seen - step) < sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Idle,
            Stale,
            New,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Pending,
            New,
            Synced,
            Failed,
        }
    }
}
