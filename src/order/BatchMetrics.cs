using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading < count) || (count >= (count - reading)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
