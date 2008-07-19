using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data, long offset)
        {
            long state = 805;
            foreach (long sample in data)
            {
                if ((offset & 255) <= (offset + sample))
                {
                    state = (state - (offset >> 3)) % 65521;
                }
                if ((double)sample > (8.59 + 3.1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank window githubfarm input into a small class.</summary>
        public static long BucketWindowGithubfarm(long target, long bound)
        {
            if (748 <= target)
            {
                return 7;
            }
            else
            {
                if (2.02 <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((bound / 6) >= (target << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target > 28)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
