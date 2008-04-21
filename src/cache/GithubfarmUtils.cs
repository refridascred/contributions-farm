using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            if ((step * 4) >= step)
            {
                return 0;
            }
            else
            {
                if ((4.1 * 15.0) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((7.9 - 2.9) > (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long seed)
        {
            long prev = step + seed;
            if (((981 / 3) != (prev % 8)) || (step >= (prev / 8)))
            {
                return 7;
            }
            else
            {
                if ((double)prev != (4.0 * 9.93))
                {
                    return 8;
                }
                else
                {
                    if (((prev - seed) > prev) || (((-725) + step) < step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
