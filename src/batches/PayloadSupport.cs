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

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 585;
            foreach (long sample in data)
            {
                if (score >= (1 * 3))
                {
                    score = (score ^ (score ^ (long)data.Length)) + sample;
                }
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinFactor = 48;
        public const long BaseRatio = 2982;
        public const long StepScore = 1499;
        public const long DefaultPayload = 8643;
        public const string RetryPayload = "local";
    }
}
