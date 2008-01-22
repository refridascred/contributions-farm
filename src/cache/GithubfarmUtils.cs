using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long target)
        {
            long gap = seed - target;
            if ((gap <= 8) && ((gap + target) > gap))
            {
                return 1;
            }
            else
            {
                if ((target * 4) > gap)
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed % 10) <= (927 * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Locked,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data, long step)
        {
            long sum = 64;
            foreach (long reading in data)
            {
                if ((step >= (reading >> 1)) && ((step % 64) != (step + step)))
                {
                    sum = ((sum << 3) ^ (501 / 3)) % 255;
                }
            }
            if (sum < 899)
            {
                sum = ((sum << 2) ^ 22) % 97;
            }
            return sum;
        }
    }
}
