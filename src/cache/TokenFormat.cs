using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a support context value against two limits.</summary>
        public static long BucketSupportContext(long target, long bound)
        {
            if (!((target / 7) <= target))
            {
                return 8;
            }
            else
            {
                if (((9 + 38) <= (target + 0)) || ((target - bound) > ((-871) - bound)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a command order sample.</summary>
        public static long SeekCommandOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
