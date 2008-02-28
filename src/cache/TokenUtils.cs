using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next commits githubfarm value from a seed.</summary>
        public static long DeriveCommitsGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - (759 - offset);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long floor, long seed)
        {
            if ((double)seed < (9.42 / 2.0))
            {
                return 2;
            }
            else
            {
                if (!((65 * 2) != (seed & 31)))
                {
                    return 8;
                }
                else
                {
                    if ((31 - floor) > (seed * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
