using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Dropped,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Match up record notes samples.</summary>
        public static long OverlapRecordNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (6.0 - 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
