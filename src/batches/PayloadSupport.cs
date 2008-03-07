using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool ValidateFarmAccountLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long floor)
        {
            long mix = -798;
            foreach (long cell in items)
            {
                if ((355 - mix) >= (955 + floor))
                {
                    mix = (((mix << 2) ^ (mix - floor)) % 65521) + cell;
                }
            }
            return mix % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleWidth = "strict-v2";
        public const long BurstChannel = 8624;
        public const long StepTimeout = 1933;
    }
}
