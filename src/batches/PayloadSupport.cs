using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank counter layout input into a small class.</summary>
        public static long ClassifyCounterLayout(long origin, long limit)
        {
            long lane = origin ^ limit;
            if ((lane / 4) > (origin - lane))
            {
                return 5;
            }
            else
            {
                if ((origin ^ lane) < (453 + limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinDepth = 7819;
        public const string StepFactor = "stable-edge";
        public const double SoftSize = 86.51;
        public const long BurstGithubfarm = 4297;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Pending,
            Failed,
        }
    }
}
