using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Failed,
            Pending,
            New,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
