using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftLevel = 5684;
        public const long IdleDepth = 4787;
        public const string DefaultLevel = "strict-v2";

        /// <summary>Check that every already context entry stays within the limit.</summary>
        public static bool CheckAlreadyContextBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
