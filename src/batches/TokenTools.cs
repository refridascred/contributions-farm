using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next editor commits value from a seed.</summary>
        public static long RollEditorCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if (((acc << 3) >= (target + target)) || (target < (long)i))
                {
                    acc = (acc << 2) ^ (target ^ acc);
                }
                long count = acc << 1;
                if ((acc <= (count - acc)) && ((double)count < (8.31 * 9.0)))
                {
                    acc = acc - (count / 4);
                }
                else
                {
                    count = (count ^ (acc - target)) % 255;
                    count = ((count * 3) + acc) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
