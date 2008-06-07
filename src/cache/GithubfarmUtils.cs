using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + cell) == (cell * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Active,
            Queued,
            Retry,
        }
    }
}
