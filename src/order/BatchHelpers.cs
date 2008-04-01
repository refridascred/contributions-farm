using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
