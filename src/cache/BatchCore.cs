using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "stable-v2";
        public const long CacheFactor = 3774;
        public const long IdleWindow = 2202;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels, long target)
        {
            long sum = -44;
            foreach (long sample in levels)
            {
                if (((18.0 + 7.4) > (double)sum) || ((target << 2) > (sample & 15)))
                {
                    sum = ((sum << 2) ^ (target / 6)) % 4096;
                    continue;
                }
                sum = ((sum * 4) + (target ^ sum)) % 97;
            }
            return sum;
        }
    }
}
