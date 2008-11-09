using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batches channel value.</summary>
        public static double ScaleBatchesChannel(double bias, double span)
        {
            double scale = span;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) - (double)(long)i) + bias;
            }
            return scale - (scale * 11.0);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Active,
            Done,
            Queued,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Active,
            Paused,
            Locked,
            Stale,
        }
    }
}
