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

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                anchor = (anchor * 4) + (anchor - sample);
            }
            if (anchor < 482)
            {
                anchor = (anchor + ((long)samples.Length >> 1)) % 1000;
            }
            return anchor % 1000;
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
