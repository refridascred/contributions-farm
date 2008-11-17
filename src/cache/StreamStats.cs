using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 9998;
        public const string HardAlready = "alpha-v2";
        public const long CacheInterval = 7761;
        public const long MinAlready = 1522;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long step)
        {
            long step2 = seed - step;
            if ((88 < (step & 127)) && ((step ^ 437) < step2))
            {
                return 1;
            }
            else
            {
                if ((step - step) != (step2 * 4))
                {
                    return 0;
                }
                else
                {
                    if ((35 - step2) != (step2 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}
