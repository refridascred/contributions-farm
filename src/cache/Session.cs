using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate filter commits samples.</summary>
        public static long TallyFilterCommits(long[] values, long seed)
        {
            long score = -4;
            foreach (long value in values)
            {
                score = ((score ^ value) % 97) - seed;
                score = (score - (score << 3)) % 97;
            }
            return score;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
