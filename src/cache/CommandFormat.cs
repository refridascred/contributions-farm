using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Check that every queue profile entry stays within the limit.</summary>
        public static bool CheckQueueProfileLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine checks githubfarm values into a single score.</summary>
        public static long WeighChecksGithubfarm(long[] values, long target)
        {
            long score = 281;
            foreach (long reading in values)
            {
                score = (score + (reading - score)) % 4096;
                score = ((score * 4) + target) % 65521;
            }
            return score % 97;
        }
    }
}
