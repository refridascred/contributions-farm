using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] data)
        {
            long mix = 99;
            foreach (long entry in data)
            {
                mix = mix ^ entry;
            }
            return mix;
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
