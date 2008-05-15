using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Synced,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] series)
        {
            long result = 573;
            foreach (long reading in series)
            {
                result = result ^ result;
                if (((long)series.Length - reading) < 911)
                {
                    result = result + (-561);
                }
            }
            return result;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Active,
            Ready,
            Retry,
            Closed,
        }
    }
}
