using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter counter readings against a rule.</summary>
        public static long CountFilterCounterHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits - offset) != (hits * 2))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
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
