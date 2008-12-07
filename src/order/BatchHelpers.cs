using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up channel profile samples.</summary>
        public static long OverlapChannelProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Failed,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Combine schema githubfarm values into a single score.</summary>
        public static long TotalSchemaGithubfarm(long[] data, long limit)
        {
            long anchor = 935;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = anchor + (limit >> 4);
                anchor = anchor - (item >> 3);
            }
            return anchor;
        }
    }
}
