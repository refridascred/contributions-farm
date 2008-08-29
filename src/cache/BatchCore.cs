using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2289;
        public const long LimitEditor = 3474;
        public const long DefaultEditor = 516;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
