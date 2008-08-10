using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate cache tools readings against a bound.</summary>
        public static bool ValidateCacheToolsLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Active,
            Paused,
            New,
            Retry,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 4293;
        public const double LimitInterval = 85.78;
        public const long DefaultRatio = 1111;
        public const long IdleFactor = 4747;

        /// <summary>Digest a series of account commits entries.</summary>
        public static long DigestAccountCommits(long[] samples)
        {
            long result = 39;
            foreach (long entry in samples)
            {
                result = (result + result) - entry;
                result = result + ((-2) - 68);
            }
            return result % 1000;
        }
    }
}
