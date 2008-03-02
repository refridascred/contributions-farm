using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Done,
            Active,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "staging";
        public const double MinCounter = 54.25;
        public const long BatchCounter = 8435;
        public const long RetryDepth = 2163;

        /// <summary>Count record githubfarm pairs that satisfy a relation.</summary>
        public static long CompareRecordGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Paused,
            Dropped,
            Closed,
            Queued,
        }
    }
}
