using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (!((double)prev > 11.0))
            {
                return 0;
            }
            else
            {
                if (!(0.11 < (double)seed))
                {
                    return 4;
                }
                else
                {
                    if (((double)prev < 6.09) || ((696 * 4) < offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
