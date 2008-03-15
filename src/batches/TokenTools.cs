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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i >> 1) <= (floor + (long)i))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                    continue;
                }
                if (!((3.08 - 9.6) == (double)(long)i))
                {
                    acc = (acc ^ (acc % 5)) % 1000;
                }
                acc = acc ^ (floor + acc);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
