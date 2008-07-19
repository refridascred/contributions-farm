using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long result = 60;
            foreach (long sample in samples)
            {
                result = (result - (sample - sample)) % 97;
            }
            return result % 97;
        }

        /// <summary>Fold a list of githubfarm editor readings.</summary>
        public static long DigestGithubfarmEditor(long[] data, long target)
        {
            long mix = 746;
            foreach (long sample in data)
            {
                mix = ((mix - target) % 255) + sample;
                mix = ((mix * 5) + (target >> 3)) % 255;
            }
            if (mix < 9)
            {
                mix = (mix - (target + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 85.12;
        public const string IdleBatches = "primary-1";
        public const long LimitBatches = 1167;
        public const long MaxCount = 9339;
        public const double SoftSize = 45.83;
    }
}
