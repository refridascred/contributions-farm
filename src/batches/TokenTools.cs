using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 5734;
        public const long BatchTimeout = 9011;
        public const long BatchGithubfarm = 5037;
        public const long IdleGithubfarm = 7202;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(((long)i ^ 64) < anchor))
                {
                    anchor = ((anchor << 2) ^ (434 >> 5)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
